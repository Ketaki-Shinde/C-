using System;
//WAP to copy an array by iterating the array.


namespace MockPractice
{
    class CopyArray
    {
        public static void Main1()
        {
            int[] arr = new int[5] { 2, 4, 6, 1, 9 };

            int[] arr1 = arr;
            Console.WriteLine("Original array elements");
            for ( int i = 0; i < arr.Length; i++)//
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("copy array elements");
            for (int i = 0; i < arr1.Length; i++)//
            {
                Console.WriteLine(arr1[i]);
            }

        }
    }
}



