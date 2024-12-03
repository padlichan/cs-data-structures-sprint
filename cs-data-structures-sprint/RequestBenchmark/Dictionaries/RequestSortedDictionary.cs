using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_data_structures_sprint.RequestBenchmark
{
    internal class RequestSortedDictionary : IRequestDictionary
    {
        // Notice this class internally uses a SortedDictionary<int, Request>
        // It is otherwise identical to RequestDictionary
        private SortedDictionary<int, Request> _sortedDictionary = [];

        public void Add(int key, Request request)
        {
            _sortedDictionary.Add(key, request);
        }

        public Request Get(int key)
        {
            return _sortedDictionary[key];
        }

        public IEnumerable<Request> GetAll()
        {
            return _sortedDictionary.Values;
        }

        public void Clear()
        {
            _sortedDictionary.Clear();
        }

        public IEnumerator<KeyValuePair<int, Request>> GetEnumerator()
        {
            return _sortedDictionary.GetEnumerator();
        }
    }
}
