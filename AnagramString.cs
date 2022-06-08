using System;
//Write a  program to check whether two strings are anagram or not?
////String str = "Pace";
//String str1 = "cape";

namespace MockProgramPractice
{
    class AnagramString
    {
        public static void Main1()
        {
           
            Console.WriteLine("Enter 1st string : ");
            String str = Console.ReadLine();
            Console.WriteLine("Enter 2nd string : ");
            String str1 = Console.ReadLine();

            Console.WriteLine("\n");

            //1st step- lower case karaycha
            String s1 = str.ToLower();
            String s2 = str1.ToLower();

            //step 2- string to character array
            char[] ch = s1.ToCharArray();
            char[] ch1 = s2.ToCharArray();

            //step3 - sort the array
            Array.Sort(ch);
            Array.Sort(ch1);

            //to see sorted array
            Console.WriteLine("String 1 :"+ch);
            Console.WriteLine("String 2 :"+ch1);
            
            //Convert char to string
            String strg = new String(ch);
            String strg1 = new string(ch1);

            // CompareTo() - strg > strg1 return 1
            //               strg < strg1 return -1
            //               strg == strg1 return 0
            if (strg.CompareTo(strg1) == 0)
            {
                Console.WriteLine("Both the strings are Anagram");
            }
            else
            {
                Console.WriteLine("Both the strings are not Anagram");
            }

        }
    }
}
