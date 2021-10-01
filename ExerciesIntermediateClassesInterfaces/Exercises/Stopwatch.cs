using System; 
using System.Timers;

namespace ExerciesIntermediateClassesInterfaces.Exercises
{
    public class Stopwatch
    {
        private Timer _timer;

        private DateTime _startTime = DateTime.MinValue;
        private TimeSpan _currentElapsedTime = TimeSpan.Zero;
        private TimeSpan _totalElapsedTime = TimeSpan.Zero;

        private bool _timerRunning = false;

        public Stopwatch()
        {
            _timer = new Timer
            {
                Interval = 1000
            };
        }

        public void Start()
        {
            Console.WriteLine("Start timer");
            // Set the start time to Now
            _startTime = DateTime.Now;
            _timer.Start();
            _timerRunning = true;
        }

        public void Stop()
        {
            Console.WriteLine("Stop timer");
            // Stop and reset the timer if it was running
            _timer.Stop();
            _timerRunning = false;
            CalculateRunTime();

        }
        private void CalculateRunTime()
        {
            var timeSinceStartTime = DateTime.Now - _startTime;
            timeSinceStartTime = new TimeSpan(timeSinceStartTime.Hours,
                                              timeSinceStartTime.Minutes,
                                              timeSinceStartTime.Seconds);
            Console.WriteLine($"Start Time: {timeSinceStartTime}");


        }

    }
}
