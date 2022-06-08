//Create an array of 10 names sort in descending order

using System;

namespace MockProgramPractice.StringPgm
{
    class NamesSortInDescendind
    {
        public static void Main()
        {
            string[] names = new string[5] { "hi", "hello", "Welcome", "to", "csharp" };
            string temp;

            for(int i = 0; i < names.Length; i++)
            {
                for(int j=i+1; j<names.Length;j++)
                {
                    if (names[i].CompareTo(names[j])>0)//unicode mdhe compare krte, lexographically
                    {
                        temp = names[i];
                        names[i] = names[j];
                        names[j] = temp;    
                    }
                }
            }
            Console.WriteLine("After Alphabetically sorted");
            for(int i=0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

        }
    }
}
