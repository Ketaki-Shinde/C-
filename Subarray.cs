using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockProgramPractice
{
    public class Subarray
    {
        public int LongSub(int input1, int[] input2)
        {
            int j;
            int max = 0;
            int zero, ones;
            for(int i=0;i<input1;i++)
            {
                zero = 0;
                ones = 0;
                for(j=0;j<input1;j++)
                {
                    if (input2[i]==0)
                    {
                        zero++;
                    }
                    else
                    {
                        ones++;
                    }
                    if(zero==ones)
                    {
                        max = max > (j - i + 1) ? max : j - i + 1;
                    }
                }
            }
            Console.WriteLine(max);
                throw new NotImplementedException("Method Large");
        }
        static void Main1(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Subarray sub = new Subarray();
            sub.LongSub(size, arr);
        }
    }
}
