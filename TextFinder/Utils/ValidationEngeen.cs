using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFinder;
using TextFinder.Model;
using TextFinder.Properties;

namespace TextFinder.Utils {
    class ValidationEngeen {

        public EventHandler<LogTextEventArgs> ValidatedInfo;
        private int amountOfThreads;
        private int amountPagesToScan;

        public void SendValidatedDataInfo(string logText) {
            ValidatedInfo(this, new LogTextEventArgs(logText, null, Color.Red));
        }
        public bool ValidateTextFieldsData(EnteredDataClass dataObj) {

            bool result = true;
            if (!Uri.IsWellFormedUriString(dataObj.URI, UriKind.Absolute))
            {
                SendValidatedDataInfo(Resources.WrongUriMessage);
                result = false;
            }
            if (!int.TryParse(dataObj.UriToScanCount, out amountPagesToScan)
                || (amountPagesToScan < 1))
            {
                SendValidatedDataInfo(Resources.AmountOfURI_ToScan);
                result = false;
            }
            if (!int.TryParse(dataObj.ThreadsCount, out amountOfThreads)
                || (amountOfThreads < 1))
            {
                SendValidatedDataInfo(Resources.ThreadValidationMessage);
                result = false;
            }
            if (dataObj.SearchedWord.Equals(""))
            {
                SendValidatedDataInfo(Resources.EmptySearchedString);
                result = false;
            }
            return result;
        }
    }
}

