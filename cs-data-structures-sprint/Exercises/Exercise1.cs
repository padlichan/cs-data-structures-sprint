using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_data_structures_sprint.Exercises
{
    internal class Exercise1
    {       
        public static void PrintExesAndOhs(int n)
        {
            char[,] TwoDArray = new char[n, n];
            
            
            char letter = 'x';

            for (int i = 0; i < TwoDArray.GetLength(0); i++)
            {
                for (int j = 0; j < TwoDArray.GetLength(1); j++)
                {
                    TwoDArray[i,j] = letter;
                    if (letter == 'x') letter = 'o';
                    else letter = 'x';
                    Console.Write(TwoDArray[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
