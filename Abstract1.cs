using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class A
    { 
        public abstract void  Add();
        public abstract void  Sub();
        public abstract void  Mul();
    }
    class Abstract1 : A
    {
        int i = Convert.ToInt32(Console.ReadLine());
        int j = Convert.ToInt32(Console.ReadLine());
        public override void  Add()
        {
            Console.WriteLine("Addition of two numbers is : "+ (i+j) );
        }
        public override void Sub()
        {
            Console.WriteLine("Subtraction of given two numbers is : "+ (i-j) );
        }
        public override void Mul()
        {
            Console.WriteLine("Product of given two numbers is  : "+ (i*j) );
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");            
            Abstract1 a1 = new Abstract1();
            a1.Add();
            a1.Sub();
            a1.Mul();
            Console.Read();
        }
    }
}
