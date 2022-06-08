using System;
////WAP to add elements to single dimensional int array and print elements from 1D array

namespace MockProgramPractice
{
    internal class _1DArraypgm
    {
        public static void Main1()
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter elements into array");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            //to print array elememts
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("array elements are : " + arr[i]);
            }

        }
    }
}
