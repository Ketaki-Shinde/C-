using System;
//WAP to search for a given number in an array and accordingly print the index if exists.

namespace MockPractice
{
   internal class Search_Ele_array
    {
        public static void Main1()
        {
            int[] arr = new int[6] {10,25,5,4,13,6 };
            Console.WriteLine("Enter ellement to be search in array :");
            int num = Convert.ToInt32(Console.ReadLine());//5

            bool isExist = true;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)//10==5
                {
                    Console.WriteLine("Index of found element in array :" + i);
                    
                    isExist = false;

                }
                else
                {
                    Console.WriteLine("Not found");
                   
                }
            }


        }
        
    }
}
