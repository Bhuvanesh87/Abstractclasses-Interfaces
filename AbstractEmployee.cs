using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Abstract2
    {
        protected int EmpNumber;
        protected string EmpName;
        protected string DeptName;
        protected string Address;
        protected  int Age;
        protected double Salary;
        public  abstract void getEmpData();
        public virtual void DisplayData()
        {
            Console.WriteLine("Enter employee details");
            Console.WriteLine("Employee Id is " + this.EmpNumber);
            Console.WriteLine("Employee EmpName is " + this.EmpName);
            Console.WriteLine("Employee Department is : " + this.DeptName);
            Console.WriteLine("Employee Address is : " + this.Address);
            Console.WriteLine("Employee Age is : " + this.Age);
            Console.WriteLine("Employee Salary is : " + this.Salary);
         }
    }
    class Employee :Abstract2
    {
        public override void getEmpData()
        {
            Console.WriteLine("Enter Employee Details ");
            Console.WriteLine("Enter Employee Number");
            this.EmpNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            this.EmpName = Console.ReadLine();
            Console.WriteLine("Enter Department Name");
            this.DeptName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            this.Address = Console.ReadLine();
            Console.WriteLine("Enter Age");
            this.Address = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            this.Salary = Convert.ToDouble(Console.ReadLine());
        }
        public override void DisplayData()
        {
            Console.WriteLine("The Employee details");
            Console.WriteLine("Employee id :" + this.EmpNumber);
            Console.WriteLine("Employee Name : " + this.EmpName);
            Console.WriteLine("Employee Department name is : " + this.DeptName);
            Console.WriteLine("Employee Address is :" + this.Address);
            Console.WriteLine("Employee Age is : " + this.Age);
            Console.WriteLine("Employee Salary is " + this.Salary);
        }
    }
    class AbstractEmployee 
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.getEmpData();
            Console.WriteLine("-----------------------");
            e1.DisplayData();
            Console.Read();
        }
    }
}
