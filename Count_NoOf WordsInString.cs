using System;
//Write a program to count the number of words in a string

namespace MockPractice
{
    class Count_NoOf_WordsInString
    {
        public static void Main1()
        {
            string str = "Welcome to Csharp tutorial";

            string[] s1 = str.Split(" ");

            int counter = 0;
            for (int i=0; i < s1.Length;i++)
            {
                counter++;
            }
            Console.WriteLine("No of words in String are : "+counter);
        }
    }
}
