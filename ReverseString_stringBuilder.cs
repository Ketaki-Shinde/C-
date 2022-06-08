using System;
using System.Text;
//reverse string using stringbuilder
//check string pallindrome or not

namespace MockPractice
{
    class ReverseString_stringBuilder
    {
        static void Main1(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello");

            string str = sb.ToString().ToLower();
            Console.WriteLine(str);
            string reverse = "";

            for(int i = str.Length-1; i >= 0 ; i--)
            {
                reverse = reverse + str[i];
            }
            Console.WriteLine("Reverse string is : "+reverse);
          

            //check Palindrome string
            if(str.Equals(reverse))
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
