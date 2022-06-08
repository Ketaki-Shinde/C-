//Write a  program to find the duplicate words and their number of occurrences in a string

namespace MockPractice
{
    class DuplicateWordAndCount
    {
        public static void Main1()
        {
            Console.WriteLine("ENter string");
            string str = Console.ReadLine();
           
            
            //str = str.ToLower();
            string[] words = str.Split(" ");

            for (int i=0;i<words.Length;i++)//i=0 0<33
            {
                int count = 1;
                bool isVisited = false;

                for(int k=i-1;k>=0;k--)
                {
                    if (words[i] == words[k])
                    {
                        isVisited = true;
                        break;
                    }
                   
                }
                if (isVisited == false)
                {
                    for (int j = i + 1; j < words.Length; j++)//j=1 
                    {

                        if (words[i] == words[j])
                        {
                            count++;

                        }
                    }
                    if (count > 1)
                    {
                        Console.WriteLine(words[i] + " " + count);
                    }
                }
            }
           
        }
    }
}
