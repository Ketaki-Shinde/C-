using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockPractice
{
    class CoprimeNo_pair
    {
        static void Main1(string[] args)
        {
            int num;
            Console.WriteLine("Enter number : ");
            num = Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=num;i++)
            {
                int c = 0;

                for(int j=1;j<=i;j++)
                {
                    if (num % j == 0 && i%j==0)
                    {
                        c++;
                    }
                }
                if(c==1)
                {
                    Console.WriteLine("coprime");
                }
                else
                {
                    Console.WriteLine("not coprime");
                }
            }
        }
    }
}
