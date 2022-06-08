using System;
//WAP to accept dimension of 1D array and create and
//accept data in that array. Calculate the average value of array elements.

namespace MockPractice
{
    class UserDefine1DArray
    {
        public static void Main1()
        {
            Console.WriteLine("Enter dimension of array ");
            int dim = Convert.ToInt32(Console.ReadLine());//5
            
            int[] arr = new int[dim];//5
            Console.WriteLine("ENter elements : ");
            int num,sum=0;
            double avg = 0;
            for (int i=0;i<arr.Length;i++)
            {
                num = Convert.ToInt32(Console.ReadLine());
                arr[i] = arr[i] + num;
                sum = sum + arr[i];
                avg = sum/ arr.Length;
                
            }
            Console.Write("\n");
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average : "+avg);
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write( arr[i]+"  ");
            }
        }



    }
}

