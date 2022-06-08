using System;
//Sort array in ascending order

namespace MockPractice
{
    class AscendingOrderArray
    {
        static void Main1(string[] args)
        {
            int[] arr = new int[5] { 8, 7, 9, 4, 1 };

            int temp = 0;

            Console.WriteLine("Array before sort : ");
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }

            //ascending order sort
            for(int i=0; i<arr.Length;i++)
            {
                for(int j=i+1;j<arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine("Array after sort in ascending order : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
        
    }
}
