using System;

namespace MockPractice
{
    class SumCOnsecutiveEleOfArray
    {
        static void Main1(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int sum = 0;
            for (int i = 0; i <arr.Length; i=i+2)
            {
                sum = arr[i] + arr[i + 1];
                Console.WriteLine(sum);
            }
        }
    }
}
