using System;
//Predict the output of following:what are the value of i and j [1M]

namespace MockPractice
{
    class Predict_output
    {
        public static void Main1()
        {
			int i = 1;
			while (i <= 5)
			{
				int j = 1;
				while (j <= 5)  //1<=5, 2<=5, 3<=5
				{
					if (j == 2) //1==2 no, 2==2
					{
						break;
						Console.WriteLine(j);
					}
					j++; //2
				}
				Console.WriteLine("j= " + j);//2
				Console.WriteLine("i = "+i);//1
				break;
			}
			
		}
	}
}
