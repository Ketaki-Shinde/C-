using System;


namespace MockPractice
{
    class _1D_Array_Sir
    {
        public static void Main1()
        {
            // int[] arr = new int[5] {2,4,5,6,1};

            //foreach(int i in arr)
            // {
            //     Console.Write(i+" ");
            // }




            int size = 0;
            Console.WriteLine("enter size of array ");
            size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];

            int sum = 0, avg = 0,counter=0;
            Console.WriteLine("Enter elements into array");
            
            for (int i = 0; i < arr.Length; i++)
            {
               
                arr[i] = Convert.ToInt32(Console.ReadLine());
                counter ++;
                sum = sum + arr[i];

            }
            avg = sum / arr.Length;

            Console.WriteLine("no of elements in array: "+counter);
            Console.WriteLine("sum : " + sum);
            Console.WriteLine("avg : " + avg);








            //Console.WriteLine("Enter element to be search in array : ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //for (int i=0;i<arr.Length;i++)
            //{
            //    if(num==arr[i])
            //    {
            //        Console.WriteLine("index : "+i);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Element not found ");
            //        break;
            //    }
            //}



            //Console.WriteLine("\nElements in array are : ");
            //foreach (int i in arr)
            //{
            //    Console.Write(i + " ");
            //}

        }
    }
}
