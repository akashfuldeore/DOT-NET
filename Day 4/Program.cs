using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Assignment
{

    class Program
    {
        static void Main(string[] args)
        {
            // Manager m = new Manager("ceo","akash",2,1500);
            // Manager m1 = new Manager("ceo", "akash", 3, 2500);
            Console.WriteLine("======");
            GenralManger m1 = new GenralManger("sir", "ceo", "akash", 2, 2500);
            Console.ReadLine();


            Employee e = new Manager("Manager", "mgr", 1, 53000);
            Console.WriteLine("Empid: " + e.EMPNO + ", Name: " + e.NAME + ", Basic salary: " + e.BASIC + ", Dept No: " + e.DEPTNO);
            Console.ReadLine();
            /*
            Manager m = new GenralManger("GM", "",25000);
            Console.WriteLine("Empid: " + m.EMPNO + ", Name: " + m.NAME + ", Basic salary: " + m.BASIC);
            Console.ReadLine();
            */
            Employee ceo = new CEO("", 200000);
            Console.WriteLine("Empid: " + ceo.EMPNO + ", Name: " + ceo.NAME + ", Basic salary: " + ceo.BASIC + ", Net salary: " + ceo.CalNetSalary());
            Console.ReadLine();

            Employee ceo1 = new CEO("CEO", 1000);
            Console.WriteLine("Empid: " + ceo1.EMPNO + ", Name: " + ceo1.NAME + ", Basic salary: " + ceo1.BASIC + ", Net salary: " + ceo1.CalNetSalary());
            Console.ReadLine();
        }
    }
}
public interface IDbFunctions
{
    void Insert();
    void Update();
    void Delete();
}
public abstract class Employee : IDbFunctions
{
    //property
    private string name;
    private int empno;
    private short deptno;
    protected decimal basic;

    private static int lastempno = 0;
    public int EMPNO
    {
        get
        {
            return empno;
        }
        private set
        {
            empno = value;

        }
    }
    public string NAME
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
    public abstract decimal BASIC
    {
        set;
        get;

    }

    public short DEPTNO
    {
        set
        {
            if (value > 0)
                deptno = value;
            else
                Console.WriteLine("Deptartment number is not valid");
        }
        get
        {
            return deptno;
        }
    }



    public Employee(string name = "noname", short deptno = 1, decimal basic = 1000)
    {
        empno = ++lastempno;
        this.name = name;
        this.deptno = deptno;
        this.basic = basic;


    }

    public abstract decimal CalNetSalary();

    public void Insert()
    {
        Console.WriteLine("insert in employee");
    }

    public void Update()
    {
        Console.WriteLine("update in employee");
    }

    public void Delete()
    {
        Console.WriteLine("delete in employee");
    }
}
public class Manager : Employee ,IDbFunctions
{
    // decimal hra = 100;
    private string designation;
    public string DESIGNATION
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("designation cant be blank ");
            }
            else
                designation = value;
        }
        get
        {
            return designation;
        }
    }
    //ctor
    public Manager(string designation = "sir", string name = "noname", short deptno = 1, decimal basic = 1000) : base(name, deptno, basic)
    {
        this.designation = designation;

    }

    public override decimal BASIC
    {
        get
        {
            return basic;
        }
        set
        {
            if (value >= 50000 && value <= 150000)
                basic = value;
            else
                Console.WriteLine("Enter valid basic");
        }

    }



    public override decimal CalNetSalary()
    {
        if (BASIC >= 50000 && BASIC <= 150000)
        {
            decimal netSal = BASIC + 5000;
            return netSal;
        }
        return BASIC;
    }
    public new void Insert()
    {
        Console.WriteLine("Manager-IDbfunction-Insert");
    }

    public new void Delete()
    {
        Console.WriteLine("Manager-IDbfunction-Delete");
    }

    public new void Update()
    {
        Console.WriteLine("Manager-IDbfunction-Update");
    }
}
public class GenralManger : Manager ,IDbFunctions 
{
    private string Perks;

    public GenralManger(string Perks = "perksir", string designation = "ceo", string name = "noname", short deptno = 1, decimal basic = 1000) : base(designation, name, deptno, basic)
    {
        this.Perks = Perks;
    }
    public override decimal BASIC
    {
        get
        {
            return basic;
        }
        set
        {
            if (value >= 100000 && value <= 250000)
                basic = value;
            else
                Console.WriteLine("Enter valid basic");
        }
    }
    public override sealed decimal CalNetSalary()
    {
        if (BASIC >= 150000 && BASIC <= 350000)
        {
            decimal netSal = BASIC + 15000;
            return netSal;
        }
        return BASIC;
    }
    public new void Insert()
    {
        Console.WriteLine("GenralManager-IDbfunction-Insert");
    }

    public new void Delete()
    {
        Console.WriteLine("GeneralManager-IDbfunction-Delete");
    }

    public new void Update()
    {
        Console.WriteLine("GenralManager-IDbfunction-Update");
    }
}
public class CEO : Employee , IDbFunctions
{
    public CEO(string name = "Akash", decimal basic = 100, short deptno = 10) : base(name, deptno, basic)
    {
    }
    public override decimal BASIC
    {
        get
        {
            return basic;
        }
        set
        {
            if (value >= 150000 && value <= 350000)
                basic = value;
            else
                Console.WriteLine("Enter valid basic");
        }
    }

    public override decimal CalNetSalary()
    {
        if (BASIC >= 150000 && BASIC <= 350000)
        {
            decimal netSal = BASIC + 15000;
            return netSal;
        }
        return BASIC;
    }
    public new void Insert()
    {
        Console.WriteLine("CEO-IDbfunction-Insert");
    }

    public new void Delete()
    {
        Console.WriteLine("CEO-IDbfunction-Delete");
    }

    public new void Update()
    {
        Console.WriteLine("CEO-IDbfunction-Update");
    }
}


