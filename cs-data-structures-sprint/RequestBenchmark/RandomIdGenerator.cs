using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_data_structures_sprint.RequestBenchmark
{
    /// <summary>
    /// This class generates a list of random Ids
    /// </summary>
    internal class RandomIdGenerator
    {
        /// <summary>
        /// Generates a list of random Ids, ensuring no duplicates
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static List<int> GetRandomIds(int amount)
        {
            var random = new Random();
                                    
            // Generate random IDs
            var ids = new List<int>(amount);
            for (int i = 0; i < amount; i++)
            {
                while (true)
                {
                    var newId = random.Next(1, amount * 10);
                    if (!ids.Contains(newId))
                    {
                        ids.Add(newId);
                        break;
                    }
                }
            }
            return ids;
        }
    }
}
