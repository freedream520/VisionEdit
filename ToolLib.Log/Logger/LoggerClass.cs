using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logger
{
    public class LoggerClass
    {
        /// <summary>
        /// Log队列
        /// </summary>
        public static Queue<LogInfo> logQueue { get; set; } = new Queue<LogInfo>() { };

        public static void WriteLog(string info, bool ShowMsgBox = false)
        {
            logQueue.Enqueue(new LogInfo{ message = info, ex = null, logLevel = MsgLevel.Info});
            if(ShowMsgBox)
            {
                MessageBox.Show(info);
            }
        }
        public static void WriteLog(string info, MsgLevel msgLevel, bool ShowMsgBox = false)
        {
            logQueue.Enqueue(new LogInfo { message = info,ex = null, logLevel = msgLevel });
            if (ShowMsgBox)
            {
                MessageBox.Show(info);
            }
        }
        public static void WriteLog(string info, MsgLevel msgLevel, Exception ex, bool ShowMsgBox = false)
        {
            logQueue.Enqueue(new LogInfo { message = info, ex = ex, logLevel = msgLevel });
            if (ShowMsgBox)
            {
                MessageBox.Show(info);
            }
        }
        public static void WriteLog(string info, Exception ex, bool ShowMsgBox = false)
        {
            logQueue.Enqueue(new LogInfo { message = info, ex = ex, logLevel = MsgLevel.Exception });
            if (ShowMsgBox)
            {
                MessageBox.Show(info);
            }
        }
    }

    public class LogInfo
    {
        public string message { get; set; }
        public MsgLevel logLevel { get; set; }
        public Exception ex { get; set; }
    }
}
