using System;
//WAP to print following pattern. 
//  *****
//   ****
//    ***
//    **
//     *


namespace MockPractice
{
    class downPyramid
    {
        public static void Main1()
        {
            for (int row=5; row >= 1; row--)
            {
                for(int space = row-1;space>=row;space--)
                {
                    Console.Write(" ");
                }
                for(int col=row; col>=1; col--)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }

        }
    }
}
