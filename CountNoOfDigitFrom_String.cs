using System;
//write a code to count no of digit from the string

namespace MockPractice
{
    class CountNoOfDigitFrom_String
    {
        public static void Main1()
        {
            string str = "Password is 1234 and name is 5678";

            //str = str.ToLower();

            //string[] words=str.Split(" ");
            int count = 0;
            for(int i=0;i<str.Length;i++)
            {
                if (str[i]>=48 && str[i]<=57)
                {
                    count++;
                }
            }
            Console.WriteLine("Count of digits in string : " + count);
            
        }
    }
}
