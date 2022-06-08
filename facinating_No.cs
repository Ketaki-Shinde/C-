using System;
//take 3 digit number from user multiply that no by 1,2 and 3 concatenate the ouput
//if output contain digit bet 1 to 9 only once then
//display no is facinating number if output contain duplicate digit
//then no is not facinating number.

namespace MockPractice
{
    class facinating_No
    {
        public static void Main1()
        {
            Console.WriteLine("Enter 3 digit number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            int mult = 0,mult1=0;
            string concat;
           // int count = 0;

            mult = num * 2 ;
            mult1 = num * 3;

            concat = num+""+mult +""+ mult1;

            Console.WriteLine("String concatination : "+concat);

            char[] ch = concat.ToCharArray();
           

           

            for (int i = 0; i < ch.Length; i++)//i=0 0<33
            {
                int count = 1;
                bool isVisited = false;

                for (int k = i - 1; k >= 0; k--)
                {
                    if (ch[i] == ch[k])
                    {
                        isVisited = true;
                        break;
                    }

                }
                if (isVisited == false)
                {
                    for (int j = i + 1; j < ch.Length; j++)//j=1 
                    {

                        if (ch[i] == ch[j])
                        {
                            count++;

                        }
                    }
                    if (count > 1)
                    {
                        Console.WriteLine(ch[i] + " " + count);
                    }
                }
            }

        }
    }
}
