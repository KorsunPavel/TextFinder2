using System.Drawing;

namespace TextFinder {
    public class LogTextEventArgs {
        public string _logText;
        public int? _progressBarValue;
        public Color? _fontColor;
        public bool _taskIsCanceled;
        public LogTextEventArgs(string logText, int? progressBarValue = null, Color? fontColor = null, bool taskIsCanceled = false) {
            _logText = logText;
            _progressBarValue = progressBarValue;
            _fontColor = fontColor ?? Color.Yellow;
            _taskIsCanceled = taskIsCanceled;
        }

    }
}
