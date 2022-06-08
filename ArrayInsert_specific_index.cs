using System;
//WAP to insert an element in a specific position into an array.


namespace MockPractice
{
    class ArrayInsert_specific_index
    {
        public static void Main1()
        {

            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            int[] newarr = new int[arr.Length + 1];
            Console.WriteLine("Enter element ");
            int element = Convert.ToInt32(Console.ReadLine());//10

            Console.WriteLine("Enter index to add element");
            int index = Convert.ToInt32(Console.ReadLine());//4

            for (int i = 0; i < arr.Length + 1; i++)//0 0<6
            {
                if (i < index - 1)//0<3
                {
                    newarr[i] = arr[i];

                }
                else if (i==index-1)
                {
                    newarr[i] = element;
                }
                else
                {
                    newarr[i] = arr[i - 1];
                }
                
            }

            //print updated array
            for(int i=0; i<arr.Length+1;i++)
            {
                Console.Write(newarr[i]);
                Console.Write("\t");
            }
            

        }
        
    }
}
