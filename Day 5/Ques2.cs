using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Da5Assignment
{
    class Ques2
    {
        static void Main()
        {
            int studNumbers;
            int studMarks;
        Console.WriteLine("Enter the number of batches: ");
            int batches = Convert.ToInt32(Console.ReadLine());

            Student[][] studArr = new Student[batches][];

            for (int i = 0; i < studArr.Length; i++)
            {
                
                Console.WriteLine("Enter the number of students for {0} batch", i + 1);
                studNumbers = Convert.ToInt32(Console.ReadLine());
                studArr[i] = new Student[studNumbers];
                for (int j = 0; j < studArr[i].Length; j++)
                {

                    studArr[i][j] = new Student();
                    Console.WriteLine("Enter the marks for student no {0} for {1} batch",j+1, i + 1);
                    studMarks = Convert.ToInt32(Console.ReadLine());
                    studArr[i][j].Acceptmarks(studMarks);
                }
            }
            Console.ReadLine();
            for (int i = 0; i < studArr.Length; i++)
            {
                for (int j = 0; j < studArr[i].Length; j++)
                {
                    Console.WriteLine("The marks for student no {0} for {1} batch", j + 1, i + 1);
                    studArr[i][j].Showmarks();
                }
            }
            Console.ReadLine();
        }
    }

    class Student
    {

      public int studMarks;

        public void Acceptmarks(int marks)
        {
            this.studMarks = marks;
        }
        public void Showmarks()
        {
            Console.WriteLine("Student Marks: " + studMarks);
        }
    }

}
