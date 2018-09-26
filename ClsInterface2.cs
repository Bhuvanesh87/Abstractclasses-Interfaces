using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface A1
    {
        void Paint();
    }
    interface B
    {
        void Paint();
    }
    class ClsInterface2 : A1, B
    {
        public void Paint()
        {
            Console.WriteLine("Paint method in CLsInterface class");
        }

        static void Main()
        {
            ClsInterface2 c1 = new ClsInterface2();
            A1 a1 = (A1)c1;
            B b1 = (B)c1;

            // The following lines all call the same method.
            c1.Paint();
            a1.Paint();
            b1.Paint();
            Console.Read();
        }
    }
}
