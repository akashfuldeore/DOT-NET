using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Da5Assignment
{
    class Ques3
    {
        static void Main()
        {
            string Name;
            int rollNo;
            decimal marks;
            StudentStruct[] studArr = new StudentStruct[5];

            for (int i = 0; i < studArr.Length; i++)
            {
                
                Console.WriteLine("Enter the details for {0} student", i + 1);
                Console.WriteLine("Enter the Student roll no: ");
                rollNo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Student name: ");
                Name = Console.ReadLine();

                Console.WriteLine("Enter the Student marks: ");
                marks = Convert.ToInt32(Console.ReadLine());

                studArr[i] = new StudentStruct(Name, rollNo, marks);

                Console.ReadLine();
            }
            for (int i = 0; i < studArr.Length; i++)
            {
                studArr[i].showStud();
            }
            Console.ReadLine();
        }
    }
    public struct StudentStruct
    {
        string Name;
        int rollNo;
        decimal marks;
        public StudentStruct(string name , int rno , decimal marks)
        {
            this.Name = "default";
            this.marks = 40;
            this.rollNo = 1;

            this.ROLLNO = rno;
            this.NAME = name;
            this.MARKS = marks;
        }

        public void showStud()
        {
            Console.WriteLine("Student Details: ");
            Console.WriteLine("\tName: "+Name);
            Console.WriteLine("\tRoll NO: " + rollNo);
            Console.WriteLine("\tMarks: " + marks);
            Console.WriteLine();

        }

        #region Validations
        public string NAME
        {
            set
            {
                if (value != "")
                {
                    Name = value;
                }
                else 
                {
                    Console.WriteLine("Value shoud not be blank");
                }
            }
            get 
            {
                return Name;
            }
        }

        public int ROLLNO
        {
            set
            {
                if (value > 0)
                {
                    rollNo = value;
                }
                else
                {
                    Console.WriteLine("Enter valid value");
                }
            }
            get
            {
                return rollNo;
            }
        }

        public decimal MARKS
        {
            set
            {
                if (value > 0 && value <100)
                {
                    marks = value;
                }
                else
                {
                    Console.WriteLine("Enter valid marks");
                }
            }
            get
            {
                return marks;
            }
        }
        #endregion


    }
}
