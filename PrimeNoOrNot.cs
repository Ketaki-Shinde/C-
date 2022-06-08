using System;
//pgm to check whether a given number is prime or not

namespace MockProgramPractice
{
    class PrimeNoOrNot
    {
        public static void Main1()
        {
            Console.WriteLine("Enter number to check prime no or not");
            int num = Convert.ToInt32(Console.ReadLine());
            int counter = 0;

            for(int i=2;i<num-1;i++)
            {
                if(num%i==0)
                {
                    counter++;
                }
            }
            if(counter>0)
            {
                Console.WriteLine("Number is not prime");
                    
            }
            else
            {
                Console.WriteLine("Number is prime");
            }
        }
    }
}
