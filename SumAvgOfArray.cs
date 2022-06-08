using System;


namespace MockProgramPractice
{
    class SumAvgOfArray
    {
        public static void Main1()
        {

            int size;
            Console.WriteLine("enter size of array ");
            size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];

            int sum = 0, avg = 0, counter = 0;
            Console.WriteLine("Enter elements into array");

            for (int i = 0; i < arr.Length; i++)
            {

                arr[i] = Convert.ToInt32(Console.ReadLine());
                counter++;
                sum = sum + arr[i];

            }
            avg = sum / arr.Length;

            Console.WriteLine("no of elements in array: " + counter);
            Console.WriteLine("sum : " + sum);
            Console.WriteLine("avg : " + avg);

        }
    }
}
