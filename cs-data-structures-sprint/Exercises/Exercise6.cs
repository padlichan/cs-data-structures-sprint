using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_data_structures_sprint.Exercises
{
    internal class Exercise6
    {
        public static void PrintQueue<T>(Queue<T> queue)
        {
            while(queue.Count > 0) 
            {
                Console.WriteLine(queue.Dequeue());
            }
        }

        public static void ReverseQueue<T>(Queue<T> queue)
        {
            Stack<T> stack = new Stack<T>();
            while( queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }
            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }

        

    }
}
