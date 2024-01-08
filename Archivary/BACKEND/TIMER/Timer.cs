using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivary.BACKEND.TIMER
{
    public static class Timer
    {
        private static Stopwatch stopwatch;
        private static bool isEnabled;

        static Timer()
        {
            stopwatch = new Stopwatch();
            isEnabled = true; //True kung di pa tapos opersys
        }

        public static bool IsEnabled
        {
            get { return isEnabled; }
            set { isEnabled = value; }
        }

        public static void Start()
        {
            if (isEnabled)
            {
                stopwatch.Restart();
            }
        }

        public static void Stop()
        {
            if (isEnabled)
            {
                stopwatch.Stop();
            }
        }

        public static TimeSpan ElapsedTime
        {
            get { return stopwatch.Elapsed; }
        }

        public static void DisplayElapsedTime()
        {
            MessageBox.Show($"Elapsed Time: {ElapsedTime.TotalMilliseconds} milliseconds");
        }
    }
}
