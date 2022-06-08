using System;
//WAP to print number from 1 to 50 if number is even then print as it is
//and number is odd then print negative number with its square

namespace MockPractice
{
   class evenNo_negativeWithSquarecs
    {
        public static void Main1()
        {
            for(int i=1;i<=50;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
                else if(i%2!=0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
