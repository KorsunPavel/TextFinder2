using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextFinder.Controller;
using TextFinder.Model;
using TextFinder.Properties;
using TextFinder.Utils;

namespace TextFinder {
    public partial class TextFinderForm : Form {
        bool isShowScarryPicture = true;
        public TextFinderForm() {
            InitializeComponent();
        }

        private void Start_Button_Click(object sender, EventArgs e) {

            if (isShowScarryPicture)
                isShowScarryPicture = ShowScarryPictureOnce();
            else {

                //cancelButton.Enabled = true;
                ProgressBar.Visible = false;
                cancellationTokenSource = new CancellationTokenSource();
                Log_TextBox.Text = string.Empty;
                ValidationEngeen ve = new ValidationEngeen();
                ve.ValidatedInfo += HandleLogEvent;
               
                bool passed = ve.ValidateTextFieldsData(
                    new EnteredDataClass()
                    {
                        URI = Start_Page_URI_textBox.Text,
                        SearchedWord = target_word_textBox.Text,
                        ThreadsCount = Threads_textBox.Text,
                        UriToScanCount = Amount_of_pages_textBox.Text
                    });

                if (passed)
                    StartSearchng();
            }
        }

        private bool ShowScarryPictureOnce() {
            Scarry sc = new Scarry();
            sc.scarryEventHandler += HandleLogEvent;
            return sc.ScarryMyFriends();
        }

        private void HandleLogEvent(object sender, LogTextEventArgs e) {
            Action action = () =>
            {
                Log_TextBox.ForeColor = e._fontColor.Value;
                Log_TextBox.Text += e._logText + Environment.NewLine;
                if (e._progressBarValue != null)
                {
                    ProgressBar.Value = e._progressBarValue.Value;
                    if (ProgressBar.Value == int.Parse(Amount_of_pages_textBox.Text))
                        Start_Button.Enabled = true;
                }
                if (e._taskIsCanceled)
                {
                    Start_Button.Enabled = true;
                    cancelButton.Enabled = false;
                }
            };
            if (InvokeRequired)
                Invoke(action);
            else
                action();
        }

        private void StartSearchng() {
            int amountPagesToScan = int.Parse(Amount_of_pages_textBox.Text);
            int amountOfThreads = int.Parse(Threads_textBox.Text);
            Start_Button.Enabled = false;
            cancelButton.Enabled = true;
            ProgressBar.Maximum = amountPagesToScan;
            ProgressBar.Visible = true;
            SearchEngeen se = new SearchEngeen();
            se.NewLogInfo += HandleLogEvent;
            Task task = new Task(() => se.BFS(Start_Page_URI_textBox.Text, amountPagesToScan, target_word_textBox.Text, amountOfThreads, cancellationTokenSource)
            , cancellationTokenSource.Token);
            task.Start();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            MyTaskCancel();
        }

        private void MyTaskCancel() {
            cancelButton.Enabled = false;
            Start_Button.Enabled = false;
            ProgressBar.Visible = false;
            Log_TextBox.ForeColor = Color.Yellow;
            Log_TextBox.Text = Resources.TaskCanceled + " by clicking CANCEL button" + Environment.NewLine;
            cancellationTokenSource.Cancel();
        }
    }
}
