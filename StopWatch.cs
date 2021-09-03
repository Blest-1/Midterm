using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace MidtermStopWatch
{
    class StopWatch
    {
        public int seconds = 0;
        public int minutes = 0;
        public int hours = 0;
        public bool startKey = true;
        public bool resetKey = false;
        public bool leaveKey = false;

        public void Start()

        {
            Console.WriteLine("Press Enter to Start");

            while (startKey)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    Stop();
                }
                break;
            }
        }


        public void Stop()

        {
            Console.WriteLine("Spacebar to stop");

            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar))
            {
                Console.Write("\r Time: {00}:{1}:{2}", hours, minutes, seconds);
                if (seconds == 60)
                {
                    minutes++;
                    seconds = 0;
                }
                System.Threading.Thread.Sleep(1000);
                seconds++;
            }

            Reset(); Start();
        }


        // Can only reset 1 time before terminal closes.
        public void Reset()

        {
            Console.WriteLine("Esc to reset");
            Console.WriteLine("BackSpace to Exit");

            while (resetKey)
            {

                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    //Console.WriteLine("\nPeace Out");
                    Console.ReadKey();
                    Console.Clear();
                }

                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    Stop();
                }
                break;
            }
        }
    }
}