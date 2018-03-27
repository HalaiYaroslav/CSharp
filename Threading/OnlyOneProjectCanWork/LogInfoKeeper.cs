using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace OnlyOneProjectCanWork
{
    class LogInfoKeeper
    {
        string threadName;
        public string ThreadName { get => threadName; set => threadName = value; }

        DateTime startWorkTime;
        public DateTime StartWorkTime { get => startWorkTime; set => startWorkTime = value; }

        DateTime endWorkTime;
        public DateTime EndWorkTime { get => endWorkTime; set => endWorkTime = value; }

        private static readonly Mutex mutex = new Mutex();

        public LogInfoKeeper()
        {

        }

        public LogInfoKeeper(string threadName, DateTime startWorkTime)
        {
            ThreadName = threadName;
            StartWorkTime = startWorkTime;
        }

        public void SaveLogInfo()
        {
            mutex.WaitOne();
            var sw = new StreamWriter(@"D:\LogFile.log", true);
            sw.WriteLine(ToString());
            sw.Close();

            Console.WriteLine($"Log info had written. {threadName}");
            mutex.ReleaseMutex();
        }

        public override string ToString()
        {
            return $"Thread name: {ThreadName} | Start work at {StartWorkTime} | End work at {endWorkTime}";
        }
    }
}
