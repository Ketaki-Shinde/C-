using System;
//) write a program to check given number is trimorphic  number or not
//4 is trimorphic number as its cube(64) contains 4  at the end .
//5 is trimorphic number as its cube (625)contains 5 at the end.


namespace MockPractice
{
    class Trimorphic_number
    {
        public static void Main1()
        {
            Console.WriteLine("Enter number to check it is trimorphic or not");
            int num = Convert.ToInt32(Console.ReadLine());

            int mult ;
            int rem = 0;
            mult = num * num * num;
            Console.WriteLine(mult);//125

            while(mult!=0)
            {
                rem = mult % 10;//5
                Console.WriteLine(rem);//5
                
                mult = mult / 10;//125/10 
                break;
                
            }
            if (num == rem)
            {
                Console.WriteLine("No is trimorphic ");

            }
            else
            {
                Console.WriteLine("No is not trimorphic ");
            }

        }
    }
}
