using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_data_structures_sprint.RequestBenchmark
{
    /// <summary>
    /// This class is a fake request for an imaginary program.
    /// We imagine that each request has an Id, and can be "processed"
    /// </summary>
    internal class Request(int id, DateTime timestamp)
    {
        public int Id { get; private set; } = id;
        public DateTime Timestamp { get; private set; } = timestamp;

        /// <summary>
        /// This method simulates some processing work with a dummy operation
        /// </summary>
        public void Process()
        {            
            var result = Id * 2;
        }
    }
}
