using System;
//WAP to print fibbo series upto 20 terms

namespace MockPractice
{
    class Fibbonacci
    {
        public static void Main1()
        {
            int num;
            Console.WriteLine("Enter term ");
            num = Convert.ToInt32(Console.ReadLine());
            int first_no = 0,third_no=0;
            int second_no = 1;
            Console.WriteLine(first_no + " " + second_no);
            for (int i=2; i<num; ++i)
            {
                third_no = first_no + second_no;
                Console.Write(" "+ third_no);//1
                first_no = second_no;//0
                second_no = third_no;//1
            }
            
        }
    }
}
