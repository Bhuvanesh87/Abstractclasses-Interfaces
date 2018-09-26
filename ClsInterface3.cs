using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface C
    {
        void Dance();
    }
    interface D
    {
        void Dance();
    }
    class ClsInterface3 : C,D
    {
            void C.Dance()
            {
                Console.WriteLine("Pop Dance");
            }
            void D.Dance()
            {
                Console.WriteLine("Break Dance");
            }
            static void Main()
            {
               ClsInterface3 ci1 = new ClsInterface3();
                C c1 = ci1;
                D d1 = ci1;          
                c1.Dance();
                d1.Dance();
                Console.Read();
        }
    }
}
