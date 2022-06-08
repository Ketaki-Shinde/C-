

using System;
//string containes only digit check sum of fisrt 3 digits and sum of last 3 digits is equal
//then that string is valid string otherwise invalid string.

namespace MockPractice
{
    class Valid_Invalid_string
    {
        public static void Main1()
        {
            string str = "123456789";

            int sum1 = 0, sum2 = 0;
            int count = 0, count1 = 0;
            
        
            for (int i=0; i<3; i++)// 0 0<3
            {
                if (str[i]>='1' && str[i]<='9')
                {
                    int x = int.Parse(str[i].ToString());
                    sum1 = sum1 + x;
  
                }
               
            }
            Console.WriteLine(sum1);


            //convert string into char array and reverse array
            char[] ch = str.ToCharArray();
            Array.Reverse(ch);

            for (int i = 0; i < 3; i++)// 0 0<3
            {
                if (ch[i] >= '1' && ch[i] <= '9')
                {
                    int x = int.Parse(ch[i].ToString());
                    sum2 = sum2 + x;
                
                }

            }
            Console.WriteLine(sum2);

            if (sum1 == sum2)
            {
                Console.WriteLine("string is valid ");

            }
            else
            {
                Console.WriteLine("string is not valid");
            }







            //for(int i=0; i < 3; i++)
            //{
            //    int x = int.Parse(str[i].ToString());
            //    sum1 = sum1 + x;
            //}
            //Console.WriteLine("Sum is: "+sum1);

            //char[] ch = str.ToCharArray();
            //Array.Reverse(ch);
            ////for(int i=0; i<ch.Length;i++)
            ////{
            ////    Console.WriteLine(ch[i]);
            ////}

            //for (int i = 0; i < 3; i++)
            //{
            //    int x = int.Parse(ch[i].ToString());
            //    sum2 = sum2 + x;
            //}
            //Console.WriteLine("Sum2 is: " + sum2);





        }
    }
}
