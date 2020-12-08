using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Assignment
{
    class Program
    {
        static void Main()
        {
            Employee1 e1 = new Employee1(E1_InvalidEmpName, E1_InvalidEmpBasic, E1_InvalidEmpDepNo,  "amol", 12000, 1);
            //e1.NAME = "amol";
            ////string E1name = e1.NAME;
            //e1.BASIC = 12000;
            ////decimal E1Basic = e1.BASIC;
            //e1.DEPTNO = 1;
            //short E1DepNo = e1.DEPTNO;
            //e1 = new Employee1(E1name, E1Basic, E1DepNo);

            Console.WriteLine("Empid: " + e1.EMPNO + ", Name: " + e1.NAME + ", Basic salary: " + e1.BASIC + ", Dept No: " + e1.DEPTNO + ", Net salary: " + e1.GetNetSalary());
            Console.ReadLine();

            Employee1 e2 = new Employee1(E2_InvalidEmpName, E2_InvalidEmpBasic, E2_InvalidEmpDepNo, "amol", 2000, 1);
            //e2.InvalidEmpName += E2_InvalidEmpName;
            //e2.InvalidEmpDepNo += E2_InvalidEmpDepNo;
            //e2.InvalidEmpBasic += E2_InvalidEmpBasic;

            //e2.NAME = "amol";
            //string E2name = e2.NAME;
            //e2.BASIC = 2000;
            //decimal E2Basic = e2.BASIC;
            //e2.DEPTNO = 1;
            //short E2DepNo = e2.DEPTNO;
           // e2 = new Employee1("amol", 2000, 1);

            //e2 = new Employee1("Amol", 25000);
            Console.WriteLine("Empid: " + e2.EMPNO + ", Name: " + e2.NAME + ", Basic salary: " + e2.BASIC + ", Net salary: " + e2.GetNetSalary());
            Console.ReadLine();

            Employee1 e3 = new Employee1(E3_InvalidEmpName, E3_InvalidEmpBasic, E3_InvalidEmpDepNo, "", 2000);

            //e3.InvalidEmpName += E3_InvalidEmpName;
            //e3.InvalidEmpDepNo += E3_InvalidEmpDepNo;
            //e3.InvalidEmpBasic += E3_InvalidEmpBasic;
            //e3.NAME = "";
            //string E3name = e3.NAME;
            //e3.BASIC = 60;
            //decimal E3Basic = e3.BASIC;
            //e3.DEPTNO = 1;
            //short E3DepNo = e3.DEPTNO;
          //  e3 = new Employee1(E3name, E3Basic);
            Console.WriteLine("Empid: " + e3.EMPNO + ", Name: " + e3.NAME + ", Basic salary: " + e3.BASIC + ", Net salary: " + e3.GetNetSalary());
            Console.ReadLine();


            Console.WriteLine("Empid: " + e3.EMPNO + ", Name: " + e3.NAME + ", Basic salary: " + e3.BASIC + ", Net salary: " + e3.GetNetSalary());
            Console.ReadLine();

            Console.WriteLine("Empid: " + e2.EMPNO + ", Name: " + e2.NAME + ", Basic salary: " + e2.BASIC + ", Net salary: " + e2.GetNetSalary());
            Console.ReadLine();

            Console.WriteLine("Empid: " + e1.EMPNO + ", Name: " + e1.NAME + ", Basic salary: " + e1.BASIC + ", Dept No: " + e1.DEPTNO + ", Net salary: " + e1.GetNetSalary());
            Console.ReadLine();
        }

        #region Invalid Basic for all objects
        private static void E1_InvalidEmpBasic(decimal Value)
        {
            Console.WriteLine("invalid Basic event code here");
            Console.WriteLine("value passed was : " + Value);
        }

        private static void E2_InvalidEmpBasic(decimal Value)
        {
            Console.WriteLine("invalid Basic event code here");
            Console.WriteLine("value passed was : " + Value);
        }

        private static void E3_InvalidEmpBasic(decimal Value)
        {
            Console.WriteLine("invalid Basic event code here");
            Console.WriteLine("value passed was : " + Value);
        }

        private static void E4_InvalidEmpBasic(decimal Value)
        {
            Console.WriteLine("invalid Basic event code here");
            Console.WriteLine("value passed was : " + Value);
        }
        #endregion

        #region Invalid Dept No for all objects
        private static void E4_InvalidEmpDepNo(short Value)
        {
            Console.WriteLine("invalid DepNo event code here");
            Console.WriteLine("value passed was : " + Value);
        }

        private static void E3_InvalidEmpDepNo(short Value)
        {
            Console.WriteLine("invalid DepNo event code here");
            Console.WriteLine("value passed was : " + Value);
        }

        private static void E2_InvalidEmpDepNo(short Value)
        {
            Console.WriteLine("invalid DepNo event code here");
            Console.WriteLine("value passed was : " + Value);
        }

        private static void E1_InvalidEmpDepNo(short Value)
        {
            Console.WriteLine("invalid DepNo event code here");
            Console.WriteLine("value passed was : " + Value);
        }
        #endregion

        #region Invalid Emp Name for all objects
        private static void E1_InvalidEmpName(string Value)
        {
            Console.WriteLine("invalid EmpName event code here");
               Console.WriteLine("value passed was : " + Value);
        }

        private static void E2_InvalidEmpName(string Value)
        {
            Console.WriteLine("invalid EmpName event code here");
            Console.WriteLine("value passed was : " + Value);
        }
        private static void E3_InvalidEmpName(string Value)
        {
            Console.WriteLine("invalid EmpName event code here");
            Console.WriteLine("value passed was : " + Value);
        }

        private static void E4_InvalidEmpName(string Value)
        {
            Console.WriteLine("invalid EmpName event code here");
            Console.WriteLine("value passed was : " + Value);
        }
        #endregion
    }

    public delegate void InvalidEmpNameHandlder(string Value);
    public delegate void InvalidEmpBasicHandlder(decimal Value);
    public delegate void InvalidEmpDepNoHandlder(short Value);
    class Employee1
    {
        private string Name;
        private static int EmpNo;
        private decimal Basic;
        private short DeptNo;

        //public static int counter;

        public event InvalidEmpNameHandlder InvalidEmpName;
        public event InvalidEmpBasicHandlder InvalidEmpBasic;
        public event InvalidEmpDepNoHandlder InvalidEmpDepNo;

        #region Constructors
        public Employee1()
        {
            //EmpNo++;
            //this.EMPNO += EmpNo;
        }
        public Employee1(InvalidEmpNameHandlder InvalidEmpName, InvalidEmpBasicHandlder InvalidEmpBasic, InvalidEmpDepNoHandlder InvalidEmpDepNo,string Name, decimal Basic, short DeptNo)
        {
            EmpNo++;
            this.InvalidEmpName += InvalidEmpName;
            this.InvalidEmpBasic += InvalidEmpBasic;
            this.InvalidEmpDepNo += InvalidEmpDepNo;
            this.EMPNO += EmpNo;
            this.NAME = Name;
            this.BASIC = Basic;
            this.DEPTNO = DeptNo;
        }
        public Employee1(InvalidEmpNameHandlder InvalidEmpName, InvalidEmpBasicHandlder InvalidEmpBasic, InvalidEmpDepNoHandlder InvalidEmpDepNo, string Name, decimal Basic)
        {
            EmpNo++;
            this.InvalidEmpName += InvalidEmpName;
            this.InvalidEmpBasic += InvalidEmpBasic;
            this.InvalidEmpDepNo += InvalidEmpDepNo;
            this.EMPNO += EmpNo;
            this.NAME = Name;
            this.BASIC = Basic;
        }
        public Employee1(InvalidEmpNameHandlder InvalidEmpName, InvalidEmpBasicHandlder InvalidEmpBasic, InvalidEmpDepNoHandlder InvalidEmpDepNo, string Name)
        {
            EmpNo++;
            this.InvalidEmpName += InvalidEmpName;
            this.InvalidEmpBasic += InvalidEmpBasic;
            this.InvalidEmpDepNo += InvalidEmpDepNo;
            this.EMPNO += EmpNo;
            this.NAME = Name;
        }
        #endregion

        #region Validations
        public string NAME
        {
            set
            {
                if (value != "")
                    Name = value;
                else
                {
                    if (InvalidEmpName != null)
                        InvalidEmpName(value);
                }
                    

            }
            get { return Name; }
        }

        public int EMPNO
        {
            get;
        }
        public decimal BASIC
        {
            set
            {
                if (value >= 10000 && value <= 50000)
                    Basic = value;
                else
                {
                    if (InvalidEmpBasic != null)
                        InvalidEmpBasic(value);
                }
            }
            get { return Basic; }
        }

        public short DEPTNO
        {
            set
            {
                if (value >= 0)
                    DeptNo = value;
                else
                {
                    if (InvalidEmpDepNo != null)
                        InvalidEmpDepNo(value);
                }
            }
            get { return DeptNo; }
        }
        #endregion

        public decimal GetNetSalary()
        {
            if (BASIC >= 10000 && BASIC <= 50000)
            {
                decimal netSal = BASIC + 1000;
                return netSal;
            }
            return BASIC;


        }


    }
}


