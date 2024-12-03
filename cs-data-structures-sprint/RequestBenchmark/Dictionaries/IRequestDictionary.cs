using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_data_structures_sprint.RequestBenchmark
{
    internal interface IRequestDictionary
    {        
        void Add(int key, Request request);
        Request Get(int key);
        IEnumerable<Request> GetAll();
        void Clear();
        IEnumerator<KeyValuePair<int, Request>> GetEnumerator();
    }
}
