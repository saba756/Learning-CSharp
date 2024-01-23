using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PracticeC_
{
    public class DesignStopWatch
    {
        // Design a class called Stopwatch.The job of this class is to simulate a stopwatch.It should
        // provide two methods: Start and Stop.We call the start method first, and the stop method next.
        // Then we ask the stopwatch about the duration between start and stop. Duration should be a
        // value in TimeSpan.Display the duration on the console.
        // We should also be able to use a stopwatch multiple times.So we may start and stop it and then
        // start and stop it again. Make sure the duration value each time is calculated properly.
        // We should not be able to start a stopwatch twice in a row (because that may overwrite the initial
        //start time). So the class should throw an InvalidOperationException if its started twice

        private double counter { get; set; }
        private Boolean isStart { get; set; }
        private long _startTime { get; set; }
        private long _stopTime { get; set; }

        public long start()
        {
           if (isStart)
            {
                throw new InvalidOperationException();
            }
           _startTime = DateTime.Now.Ticks;
            isStart = true;
            Console.WriteLine(_startTime);
            return _startTime;
        }
        public long stop()
        {
            if (!isStart)
            {
                throw new InvalidOperationException();
            }
            _stopTime = DateTime.Now.Ticks;
            isStart = false;
            printCounter();
            return _stopTime;
        }

        public void printCounter()
        {
            TimeSpan ts = TimeSpan.FromTicks(_stopTime - _startTime);
            counter = counter + ts.TotalSeconds;
            Console.WriteLine("seconds {0:0}", counter);

        }
    }
}
