
using System;
//Write a program to print all numbers between 1 and 100 except
///the numbers which are divisible by 5or 10


namespace MockPractice
{
    class Print1to100Except_DivBy5NAd10
    {
        public static void Main11()
        {
            for (int i=1; i<=100; i++)
            {
                if(i%5!=0 || i%10!=0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
