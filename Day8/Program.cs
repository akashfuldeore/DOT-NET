using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Assignment
{
    class Program
    {
        static void Main()
        {
            Employee e = new Employee();
           // decimal basic = e.BASIC;

            Func<decimal, decimal, decimal, decimal>  simp = (p,n,r) => (p * n * r) / 100;
            Console.WriteLine(simp(5000,5,3));
            Console.ReadLine();

            Func<int, int, bool> isGreat = (a, b) => a > b;
            Console.WriteLine(isGreat(5000, 5));
            Console.ReadLine();

            Func<int, bool> isEven = num => num % 2 == 0;
            Console.WriteLine(isEven(10));
            Console.ReadLine();

            Func<Employee,decimal > getBasic = emp => emp.BASIC + 3000;
            Console.WriteLine(getBasic(e));
            Console.ReadLine();

            Func<Employee, bool> checkBasic = empcheck => empcheck.BASIC > 10000;
            Console.WriteLine(checkBasic(e));
            Console.WriteLine(e.BASIC);
            Console.ReadLine();


        }
        static decimal SimpleInterest(decimal P, decimal N, decimal R)
        {
            return (P * N * R) / 100;
        }

        static bool IsGreater(int a, int b)
        {
            return a > b;
        }

        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
    }

    class Employee
    {
        decimal basic = 5000;
        
        public decimal BASIC
        {
            set 
            {
                this.basic = value;
            }
            get 
            {
                return basic;
            }
        }

    }
}
