using System;


namespace MockProgramPractice.StringPgm
{
    class CountDuplicateWords
    {
        public static void Main()
        {
            Console.WriteLine("Enter string");
            String str=Console.ReadLine();

            string[] words = str.Split(" ");

            for(int i=0;i<words.Length;i++)
            {
                int count = 1;
                bool isVisited = false;
                for(int j=i-1;j>=i;j--)
                {
                    if (words[i] == words[j])
                    {
                        isVisited = true;
                        break;
                    }
                }
                if(isVisited==false)
                {
                    for(int k=i+1; k<words.Length; k++)
                    {
                        if (words[i] == words[k])
                        {
                            count++;

                        }
                    }
                    if(count>1)
                    {
                        Console.WriteLine(words[i] + "  " + count);
                    }
                    
                }
            }
        }
        
    }
}
