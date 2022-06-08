using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockPractice
{
    class ReverseString
    {
        static void Main1(string[] args)
        {
            string str = "Ketaki";
            string reverse = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse = reverse + str[i];
            }
            Console.WriteLine("Reverse string is : " + reverse);

            //check Palindrome string
            if (reverse==str)
            {
                Console.WriteLine("String is palindrome");
            }
            else
            {
                Console.WriteLine("String is not palindrome");
            }

        }
    }
}
