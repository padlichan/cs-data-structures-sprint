using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_data_structures_sprint.Exercises
{
    internal class Exercise5
    {
        public static string StackReverseWord(string str)
        {
            // Write your code here and replace "" with your result
            // Use a Stack<string> to reverse the string
            Stack<char> stack = new Stack<char>();
            foreach(char c in str)
            {
                stack.Push(c);
            }
            char[] outputChar = stack.ToArray();
            string output = new string(outputChar);

            return output;
        }
    }
}
