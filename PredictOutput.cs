using System;
//Predict behaviour of the following code: 
//Ans: 2 2 2
namespace MockPractice
{
    class PredictOutput
    {
        public static void Main1(String[] args)
        {
            int b = 0;
            do
            {
                int a = 2;
                b++;
                Console.WriteLine(a++);//2 3 4
            }
            while (b != 3);

            /// second program
            int i = 1, k = 1;
            while (i++ <= 5)
            {
                k *= i;//1 2 6 24    120
            }
            Console.WriteLine("k ="+k+"i ="+i);
            //“k =”+k +”i =”+i
            //Ans k=720 i=7
        }
    }
}
