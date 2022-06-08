using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockPractice
{
    class ArithmaticProgression
    {
        public static void Main1(string[] args)
        {
            int second = 5, third = 8,nth = 4;

            int diff = third - second;
            int first = second - diff;
            int ap = first + (nth - 1) * diff;
            Console.WriteLine(ap);
            int term = first;
            for (int i = 0; i < nth; i++)
            {
                Console.WriteLine(term+",");
                term = term + diff;
            }
        }
    }
}
