using System;

namespace ExerciesIntermediateClassesInterfaces.Exercises
{
    public class ProcessStopWatch
    {
        public void ExeciseTimer()
        {
            var timer = new Stopwatch();
            timer.Start();
            Console.ReadLine();
            timer.Stop();
            Console.ReadLine();
        }
    }
}
