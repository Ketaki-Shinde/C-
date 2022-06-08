using System;
//Count no of vowels from string

namespace MockPractice
{
    class Count_Vowels_From_string
    {
        public static void Main1()
        {
            string str = "Welcome to csharp";

            str = str.ToLower();

            int count = 0;
            for(int i=0; i<str.Length;i++)
            {
               
                if (str[i]=='a' || str[i]=='e' || str[i]=='i' || str[i]=='o' || str[i] =='u')
                {
                    count++;
                }
            }
            Console.WriteLine("Count of vowels in string : " + count);
        }
    }
}
