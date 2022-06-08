using System;
//Sort the array in descending order

namespace MockPractice
{
    class DescendingOrderArray
    {
        static void Main1(string[] args)
        {
            int[] arr = new int[5] { 5, 2, 9, 8, 3 };


            //array in descending order
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }
                }
            }

            Console.WriteLine("Array in descending order : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
