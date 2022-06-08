using System;
//WAP to put even and odd elements of array in two separate arrays.

namespace MockPractice
{
    class EvenOddEle_seperateArr
    {
        public static void Main1()
        {
            int[] arr = new int[7] {2,3,4,5,1,6,7 };
            int even1 = 0, odd1 = 0;
            int[] even = new int[even1];
            int[] odd = new int[odd1];
            
            for (int i=0;i<=arr.Length-1;i++)
            {
                if(arr[i]%2==0)
                {
                    even[even1++] = arr[i];
                    
                }
                else
                {
                    odd[odd1++] = arr[i];
                    
                }
            }

            for(int i=0;i<even.Length;i++)
            {
                Console.Write("Even elements array:  "+even[i]);
            }
            for(int i=0;i<odd.Length;i++)
            {
                Console.Write("Odd elements array:  " + odd[i]);
            }
        }
    }
}
