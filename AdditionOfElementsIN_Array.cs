using System;


namespace MockPractice
{
    class AdditionOfElementsIN_Array
    {
        static void Main1(string[] args)
        {
            int[] arr = new int[5] {5,4,7,2,8 };
            int sum = 0;
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
                counter++;
            }
            Console.WriteLine("sum : " + sum);





        }
    }
}
