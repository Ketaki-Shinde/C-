using System;
//WAP to find the maximum and minimum value in an array.

namespace MockPractice
{
    class MaxMinElement
    {
        public static void Main1()
        {
            int[] arr = new int[] {1,5,4,9,8,2,10 };
            int min = arr[0], max = arr[0];

            for (int i=1;i<arr.Length;i++)
            {
                if (arr[i]<min)
                {
                    min = arr[i];
                }
                if(arr[i]>max)
                {
                    max = arr[i];
                    
                }
            }
            Console.WriteLine("Minimum  : "+min);
            Console.WriteLine("Maximum  : " + max);
        }
    }
}
