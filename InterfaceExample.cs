using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockPractice
{
    interface IGreet
    {
        void Msg(string msg);
    }

    interface IMath
    {
        void sum(int a, int b);
        int divide(int a, int b);
    }
    public class InterfaceExample : IMath, IGreet
    {
        int x = 10, y = 2;

        public void sum(int x, int y)
        {
            Console.WriteLine("Additin : " + (x + y));
        }

        public int divide(int x, int y)
        {
            return x / y;
        }

        public void Msg(String msg)
        {
            msg = "Welcome to csharp";
        }

        static void Main1()
        {
            IGreet obj = new InterfaceExample();
            obj.Msg("Hii");

            IMath obj1 = new InterfaceExample();
            obj1.sum(10, 2);
            Console.WriteLine("Divide : "+obj1.divide(20, 5));

        }
    }

}