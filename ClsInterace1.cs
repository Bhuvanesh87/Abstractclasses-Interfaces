using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    interface Add
    {
        void Add();
    }
    interface Sub
    {
        void Sub();
    }
    interface Mul
    {
        void Mul();
    }
    class ClsInterace1 : Add, Sub, Mul
    {        
              double i = Convert.ToDouble(Console.ReadLine());
              double j = Convert.ToDouble(Console.ReadLine());
          
        public  void Add()
        {
          Console.WriteLine("The Addition of two numbers is : "+(i+j));
        }
        public  void Sub()
        {
          Console.WriteLine("The subtraction of two numbers is : " + (i - j));
        }
        public void Mul()
        {
             Console.WriteLine("The Product of two numbers is : " + (i*j));
        }
        static void Main(string[] args)
        {
          Console.WriteLine("Enter two numbers");
          ClsInterace1 a1 = new ClsInterace1();
          a1.Add();
          a1.Sub();
          a1.Mul();
          Console.Read();
        }
    }
}
