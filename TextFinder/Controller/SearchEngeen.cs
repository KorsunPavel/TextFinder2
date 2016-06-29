using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using TextFinder.Model;
using TextFinder.Properties;

namespace TextFinder {
    public class SearchEngeen {
        BlockingCollection<Node<int, string>> inputQueue = new BlockingCollection<Node<int, string>>();

        private Node<int, string> root;
        List<string> globalList = new List<string>();
        static int nodeNumber;
        static int nodeLevel;
        static int totalMatchCount;
        static int maxCounter;

        public event EventHandler<LogTextEventArgs> NewLogInfo;

        public void SendNewLogInfo(string logText, int? progressBarValue = null, bool taskIsCanceled = false) {
            NewLogInfo(this, new LogTextEventArgs(logText, progressBarValue, Color.Yellow, taskIsCanceled));
        }

        public void BFS(string uri, int max, string searchedWord, int threadCount, CancellationTokenSource cancellationTokenSource) {
            nodeNumber = 1;
            nodeLevel = 1;
            maxCounter = 1;
            totalMatchCount = 0;
            Task[] workers = new Task[threadCount];

            for (int i = 0; i < threadCount; ++i)
            {
                int workerId = i;
                Task task = new Task(() => worker(workerId, max, searchedWord, cancellationTokenSource), cancellationTokenSource.Token);
                workers[i] = task;
                task.Start();
            }
            if (uri == null)
                return;

            root = new Node<int, string>(nodeNumber, uri, nodeLevel);

            inputQueue.Add(root);

            try
            {
                Task.WaitAll(workers);
            }
            catch (AggregateException e)
            {
                foreach (var v in e.InnerExceptions)
                    SendNewLogInfo(e.Message + " " + v.Message);
            }
            finally
            {
                cancellationTokenSource.Dispose();
            }


            SendNewLogInfo(string.Format(Resources.TotalFoundWords, totalMatchCount), max, true);
        }

        private void worker(int workerId, int max, string searchedWord, CancellationTokenSource cancellationTokenSource) {

            WebClient client = new WebClient() ;
            foreach (var nodeItem in inputQueue.GetConsumingEnumerable())
            {
                if (cancellationTokenSource.IsCancellationRequested == true)  inputQueue.CompleteAdding();
                cancellationTokenSource.Token.ThrowIfCancellationRequested();
                string textPage = GetTextString(nodeItem, client);
                if (!string.IsNullOrEmpty(textPage))
                {
                    nodeItem.children = AddChildrenNodes(textPage, nodeItem.level);
                    int matchCount = GetMatchesCount(textPage, searchedWord);
                    totalMatchCount += matchCount;

                    if (cancellationTokenSource.IsCancellationRequested == false)
                    {
                        SendNewLogInfo(string.Format(Resources.ThredIsProcessingNode, workerId, nodeItem.number));
                        SendNewLogInfo(string.Format(Resources.ResultOfProcessing, nodeItem.linkName, nodeItem.level, nodeItem.number, matchCount)
                            , maxCounter - 1);
                    }

                    foreach (var child in nodeItem.children)
                    {
                        cancellationTokenSource.Token.ThrowIfCancellationRequested();
                        if (!globalList.Contains(child.linkName) && (maxCounter <= max))
                        {
                            globalList.Add(child.linkName);
                            inputQueue.Add(child);
                            Interlocked.Increment(ref maxCounter);
                        }
                        if (maxCounter > max)
                        {
                            inputQueue.CompleteAdding();
                        }
                    }
                }
                else inputQueue.CompleteAdding();
            }
        }

        private string GetTextString(Node<int, string> currentNode, WebClient client) {
            using (client)
            {
                try
                {
                    return client.DownloadString(currentNode.linkName);
                }
                catch (Exception e)
                {
                    SendNewLogInfo("Error " + e.Message);
                }
            }
            return string.Empty;
        }


        private List<Node<int, string>> AddChildrenNodes(string textPage, int nodeLevelIn) {
            nodeLevelIn++;
            List<Node<int, string>> list = new List<Node<int, string>>();
            Regex urlRx = new
            Regex(@"(<a href)(=)(.)(http:|https:[/][/]|www.)([$-_.+!*'(),][a-z]|[A-Z]|[0-9]|[/.]|[~])*",
            RegexOptions.IgnoreCase);
            MatchCollection matches = urlRx.Matches(textPage);
            foreach (Match match in matches)
            {
                nodeNumber++;
                string input = match.Value;
                string pattern = "(<a href)(=)(.)";
                string replacement = "";
                Regex rgx = new Regex(pattern);
                string result2 = rgx.Replace(input, replacement);
                string result = result2.IndexOf('?') > 0 ? result2.Substring(0, result2.IndexOf('?'))
                    : result = result2;
                list.Add(new Node<int, string>(nodeNumber, result, nodeLevelIn));
            }
            return list;
        }

        private int GetMatchesCount(string textPage, string searchedWord) {
            MatchCollection matches = Regex.Matches(textPage, searchedWord, RegexOptions.IgnoreCase);
            return matches.Count;
        }
    }
}
