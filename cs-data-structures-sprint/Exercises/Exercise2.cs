using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_data_structures_sprint.Exercises
{
    internal class Exercise2
    {
        public static void PrintFirstAndLast(LinkedList<string> list)
        {
            Console.WriteLine(list.ElementAt(0));
            Console.WriteLine(list.ElementAt(^1));
        }

        
        public static void PrintFirstAndLastGeneric<T>(LinkedList<T> list)
        {
            Console.WriteLine(list.ElementAt(0).ToString());
            Console.WriteLine(list.ElementAt(^1).ToString());
        }
        
    }
}
