using System;
//count the digits in string

namespace MockProgramPractice
{
    class CountNoOfDigitsINString
    {
        public static void Main1(String[] args)
        {
            String str = "Hello 24 Welc0me to 26";
            Console.WriteLine(str.Length);
           
            int count = 0;
            for(int i=0;i<str.Length; i++)
            {
                if ((str[i]>=48) && (str[i]<=57))
                {
                    count++;
                }
            }
            Console.WriteLine("Number of digits in string : "+count);
        }
    }
}
