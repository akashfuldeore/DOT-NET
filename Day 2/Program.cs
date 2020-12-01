using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee o1 = new Employee("", 2000, 10);
            Employee o2 = new Employee("Akash", 25000);
            Employee o3 = new Employee("Akash");


            Console.WriteLine(o1.Empno);
            Console.WriteLine(o2.Empno);
            Console.WriteLine(o3.Empno);

            Console.WriteLine(o3.Empno);
            Console.WriteLine(o2.Empno);

            Console.WriteLine(o1.Empno);
        }
    }
    class Employee
    {
        public Employee(string Name, decimal Basic, short DeptNo)
        {
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;

        }
        public Employee(string Name, decimal Basic)
        {
            this.Name = Name;
            this.Basic = Basic;
        }
        public Employee(string Name)
        {
            this.Name = Name;
        }
        public Employee()
        {

        }
        static int empno = 0;
        public int Empno
        {
            get;

            set;
        } = ++empno;
        private string name;
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("name is empty");
                }
                else
                    name = value;

            }
            get
            {
                return name;
            }
        }

        //public int EmpNo
        //{
        //    get
        //    {
        //        return empno;
        //    }
        //}
        private decimal basic;
        public decimal Basic
        {
            set
            {
                if ((value >= 20000) && (value <= 50000))
                {
                    basic = value;
                }
                else
                    Console.WriteLine("basic salary is not in range");
            }
            get
            {
                return basic;
            }
        }
        private short deptno;
        public short DeptNo
        {
            set
            {
                if (value > 0)
                    deptno = value;
                else
                    Console.WriteLine("Deptartment number is not valid");
            }
        }

    }
}
