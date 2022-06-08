using System;
//print prime number from 1 to 100

namespace MockProgramPractice
{
    class PrimeNo1to100
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("enter number");
            int num=Convert.ToInt32(Console.ReadLine());

            int counter = 0;
            for(int i=1;i<=num;i++)
            {
                
                for(int j=2;j<=i-1;j++)
                if(i%j==0)
                {
                    counter++;
                }
            }
            if(counter==0)
            {
                Console.WriteLine(""+counter);
            }
        }
    }
}
