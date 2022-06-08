using System;
//WAP to print following pattern. 
//               1
//             2 2 2
//           3 3 3 3 3
//         4 4 4 4 4 4 4


namespace MockPractice
{
    class Pyramid
    {
        public static void Main1()
        {
            
            for(int row=1; row<=5; row++)//1
            {
                for(int space=4; space>=row; space--)//4
                {
                    Console.Write(" ");
                }
                for(int col = 1; col <= row; col++)
                {
                    Console.Write(row+" ");
                    //row = row + 2;
                }
                Console.Write("\n");
            }
        }
    }
}
