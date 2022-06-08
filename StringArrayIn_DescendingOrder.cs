using System;
//Create an array of 10 names sort in descending order

namespace MockPractice
{
    class StringArrayIn_DescendingOrder
    {
        static void Main1(string[] args)
        {
            string[] name = new string[10]; //{ "ketaki", "sayali", "nikhil", "sagar", "utkarsh", "aniket", "pooja", "snehal", "raut", "saish" };
            Console.WriteLine("Enter name in array : ");

            for (int i = 0; i < name.Length; i++)
            {
                name[i] = Console.ReadLine();

            }

            //ascending sorting

            Array.Sort(name);
            Console.WriteLine("array of name after sorting :");
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i].ToLower());
            }

            //descending order
            Array.Reverse(name);
            Console.WriteLine("array of name after sorting in descending :");
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i].ToLower());

            }
        }
    }
}
