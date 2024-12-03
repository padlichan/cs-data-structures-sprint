using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_data_structures_sprint.Exercises
{
    internal class Exercise3
    {
        public static void SwapElementPosition(LinkedList<string> list, int index1, int index2)
        {
            var newElement1 = list.ElementAt(index1);
            var newElement2 = list.ElementAt(index2);
            
            var newElement1Node = list.Find(newElement1);
            var newElement2Node = list.Find(newElement2);

            newElement1Node.Value = newElement2;
            newElement2Node.Value = newElement1;

        }
    }
}
