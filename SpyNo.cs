using System;
//write a  program to check given number is spy number or not
//e.g 123 if sum of digit is equals to product of digit the number is spy number
//i.e 123=1+2+3=6 and 1*2*3=6 so the number is spy  number


namespace MockPractice
{
    class SpyNo
    {
        public static void Main1()
        {
            Console.WriteLine("Enter number ");
            int num = Convert.ToInt32(Console.ReadLine());//123
            
            int remainder = 0;
            int sum = 0;
            int mult = 1;

            while(num>0)
            {
                remainder = num % 10;//3     //2nd step:12%10=2
                sum = sum + remainder;//0+3=3     3+2=5
                mult = mult * remainder;
                num = num / 10;// 123/10=12     12/10=1 

            }
            Console.WriteLine("Sum of digits are : "+sum);
            Console.WriteLine("Multiplication of digits are :"+mult);      
            
            if(sum==mult)
            {
                Console.WriteLine("Number is spy");
            }
            else
            {
                Console.WriteLine("Number is not spy");
            }
        }
    }
}
