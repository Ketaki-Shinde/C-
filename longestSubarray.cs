using System;


namespace MockPractice
{
    class longestSubarray
    {
        static void Main1(string[] args)
        {
            //int[] a = { 1, 0, 1, 0, 1, 1, 0, 1, 0 };
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int ones = 0, zeros = 0;
            int max = 0;
            //find length of longest equal zeros and ones
            for (int i = 0; i < arr.Length; i++)
            {
                zeros = 0;
                ones = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] == 0)
                    {
                        zeros++;

                    }
                    else
                    {
                        ones++;
                    }
                    if (zeros == ones)
                    {
                        if (max < j - i + 1)
                        {
                            max = j - i + 1;
                        }
                    }
                }
                Console.WriteLine("Max : " + max);
            }
        }

    }
}
