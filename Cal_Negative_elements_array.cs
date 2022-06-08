using System;
//WAP to print all negative elements in an array
//and also count total number of negative elements in an array.

namespace MockPractice
{
    class Cal_Negative_elements_array
    {
        public static void Main1()
        {
            int[] arr = new int[6] { 1,-2,3,-4,-5,6};
            int counter = 0;
            for (int i=0; i<arr.Length;i++)
            {
                if(arr[i]<0)
                {
                    Console.WriteLine("negative elements "+arr[i]);
                    counter++;
                }
            }
            Console.WriteLine("Count od negative elements : "+counter);
        }
    }
}
