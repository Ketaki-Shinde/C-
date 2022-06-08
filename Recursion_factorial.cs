using System;


namespace MockPractice
{
    class Recursion_factorial
    {
        static int factorial(int n)
        {
            if(n==0)
            {
                return 1;
            }
            else
            {
                return n*factorial(n-1);
            }
        }
        static void Main1(string[] args)
        {
            int i, fact = 1;
            int num = 5;
            fact=factorial(num);
            Console.WriteLine("Fcatorial of "+num+" is: "+fact);
        }
    }
}
