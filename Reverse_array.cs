using System;
//WAP to print reverse of an array. Also print every alternate element backwards.


namespace MockPractice
{
    class Reverse_array
    {
        public static void Main1()
        {
            int[] arr = new int[5] {1,2,3,4,5};
                                  //4 3 2 1 0
            for(int i = arr.Length-1; i>=0;i--)//4,3,2,1,0
            {
                Console.WriteLine(arr[i]);//5
            }
        }
    }
}
