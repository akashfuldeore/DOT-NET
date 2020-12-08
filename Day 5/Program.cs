using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Da5Assignment
{
    class Program
    {
        static void Main()
        {
            Employee[] empArr = new Employee[3];
            int empNo;
            string empName;
            int salary;
            int empSearch;
            int maxSal; 
            for (int i = 0; i < empArr.Length; i++)
            {
                empArr[i] = new Employee(); 
            }

            for (int i = 0; i < empArr.Length; i++)
            {
                Console.WriteLine("Enter the details for {0} employee", i + 1);
                Console.WriteLine("Enter the Employee id: ");
                empNo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Employee name: ");
                empName = Console.ReadLine();
                
                Console.WriteLine("Enter the Employee salary: ");
                salary = Convert.ToInt32(Console.ReadLine());

                empArr[i].AcceptDetails(empName,empNo,salary);

                Console.ReadLine();

            }
            Console.WriteLine("Enter the employee id to search the employee: ");
            empSearch = Convert.ToInt32(Console.ReadLine()); 
            for (int i = 0; i < empArr.Length; i++)
            {
                if (empSearch == empArr[i].empNo)
                {
                    empArr[i].ShowDetails();
                }              
            }
            Console.ReadLine();
            maxSal = empArr[0].salary;
            for (int i = 0; i < empArr.Length; i++)
            {

                if (empArr[i].salary > maxSal)
                {
                    maxSal = empArr[i].salary;
                    Console.WriteLine(empArr[i].empName+" has the "+"maximum salary which is: " + maxSal);
                }
            }
            Console.ReadLine();
        }
        class Employee
        {
             public int empNo;
             public string empName;
             public int salary;

            public void AcceptDetails(string name,int id,int sal)
            {
                this.empNo = id;
                this.empName = name;
                this.salary = sal;
            }

            public void ShowDetails()
            {
                Console.WriteLine("Employee Record: ");
                Console.WriteLine("\tName     : " + empName);
                Console.WriteLine("\tID   : " + empNo);
                Console.WriteLine("\tSalary      : " + salary);
            }
        }
    }
}
