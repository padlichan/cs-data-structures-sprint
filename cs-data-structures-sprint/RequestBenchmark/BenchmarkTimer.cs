using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_data_structures_sprint.RequestBenchmark
{
    /// <summary>
    /// This class will time any function passed to it
    /// </summary>
    internal class BenchmarkTimer
    {
        private Stopwatch stopwatch;

        public BenchmarkTimer()
        {
            stopwatch = new Stopwatch();
        }

        public void Time(Action action, string description)
        {
            stopwatch.Restart();
            action();
            stopwatch.Stop();
            Console.WriteLine($"\"{description}\": {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
