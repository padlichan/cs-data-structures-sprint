using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_data_structures_sprint.RequestBenchmark
{
    internal class RequestDictionary : IRequestDictionary
    {
        // Notice this class internally uses a Dictionary<int, Request>
        // It is otherwise identical to RequestSortedDictionary
        private Dictionary<int, Request> _dictionary = [];

        public void Add(int key, Request request)
        {
            _dictionary.Add(key, request);
        }

        public Request Get(int key)
        {
            return _dictionary[key];
        }

        public IEnumerable<Request> GetAll()
        {
            return _dictionary.Values;
        }             

        public void Clear()
        {
            _dictionary.Clear();
        }

        public IEnumerator<KeyValuePair<int, Request>> GetEnumerator()
        {
            return _dictionary.GetEnumerator();
        }
    }
}
