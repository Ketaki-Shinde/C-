using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockPractice
{
    class ReverseStringWithout_ForLoop
    {
        static void reverse(string str)
        {
            if(str!="")
            {
                Console.Write(str[str.Length-1]);
                reverse(str.Substring(0,str.Length-1));
            }
        }
        static void Main1(String[] args)
        {
            reverse("Hello");
        }
    }
}
