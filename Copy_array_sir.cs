using System;


namespace MockPractice
{
    internal class Copy_array_sir
    {
        public static void Main1()
        {
            int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] newarr = new int[5];

            Array.Copy(arr, 5, newarr, 0, arr.Length);
            //for (int i =5; i < arr.Length; i++)
            //{
            //    newarr[i] = arr[i];
            //}

         foreach(int i in newarr)
            {
                Console.WriteLine(i);
            }
        }
       

    }
}
