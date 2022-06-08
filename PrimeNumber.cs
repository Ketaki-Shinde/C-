using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockPractice
{
    class PrimeNumber
    {
        static void Main1(String[] args)
        {

            Console.WriteLine("Enter number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool flag = false;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    flag = true;
                    break;

                }
            }
            if (!flag)
            {
                Console.WriteLine(num + " is prime number");
            }
            else
            {
                Console.WriteLine(num + " is not prime number");
            }
        }
    }
}
