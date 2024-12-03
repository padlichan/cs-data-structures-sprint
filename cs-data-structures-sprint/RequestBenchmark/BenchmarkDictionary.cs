using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_data_structures_sprint.RequestBenchmark
{
    /// <summary>
    /// This class takes either a Dictionary<int, Request> or SortedDictionary<int, Request>
    /// It then benchmarks how long it takes to add a number of items and "process" each item
    /// </summary>
    internal class PerformBenchmark
    {
        public static void Start<T>(string description, T dictionary, int numRequests) where T : IRequestDictionary
        {
            var ids = RandomIdGenerator.GetRandomIds(numRequests);

            var dictionaryTimer = new BenchmarkTimer();

            // Simulate adding requests
            dictionaryTimer.Time(() => {
                foreach (var id in ids)
                {
                    dictionary.Add(id, new Request(id, DateTime.Now));
                }
            }, $"{description} - Add Requests");

            // Simulate processing requests
            dictionaryTimer.Time(() => {
                foreach (var kvp in dictionary)
                {
                    kvp.Value.Process();
                }
            }, $"{description} - Process Requests");

            // Simulate removing processed requests
            dictionaryTimer.Time(() => dictionary.Clear(), $"{description} - Remove Processed Requests");

        }
    }
}
