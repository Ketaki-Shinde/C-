using System;
//Write two methods that return the average of an array with following headers.
//a. public static int average(int[] array)
//b. public static double average(double[] array).
//Write main and invoke the 2 methods.


namespace MockPractice
{
    class Average_Methods
    {
        public static void Main1()
        {
            int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double[] arr1 = new double[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            Average(arr);
            Console.WriteLine(Average(arr));
            Average(arr1);
            Console.WriteLine(Average(arr1));
        }

        static int sum = 0,avg = 0,counter = 0;
        public static int Average(int[]arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                counter++;
                sum += arr[i];
            }
            avg = sum / counter;
            return avg;
        }

        static double add = 0, avg1 , counter1 = 0;
        public static double Average(double[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                counter1++;
                add += arr[i];
            }
            avg1 = sum / counter;
            return avg1;
        }
    }
}
