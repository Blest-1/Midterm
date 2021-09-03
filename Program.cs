using System;
using System.Timers;

namespace MidtermStopWatch
{
    class Program

    {
        static void Main(string[] args)

        {
            var startKey = new StopWatch();
            startKey.Start();

            var stopwatch = new StopWatch();
            stopwatch.Stop();

            var resetKey = new StopWatch();
            resetKey.Reset();
        }
    }
}

