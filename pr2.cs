using System;

interface IPayroll
{
    void CalculateSalary();
}

class Employee
{
    protected int empId;
    protected string name;

    public Employee(int id, string empName)
    {
        empId = id;
        name = empName;
    }

    public virtual void Display()
    {
        Console.WriteLine($"\nID: {empId} | Name: {name}");
    }
}

class FullTimeEmployee : Employee, IPayroll
{
    private double basicSalary;
    private double netSalary;

    public FullTimeEmployee(int id, string empName, double salary) : base(id, empName)
    {
        basicSalary = salary;
    }

    public void CalculateSalary()
    {
        netSalary = basicSalary + (basicSalary * 0.20);
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Type: Full-Time | Net Salary: {netSalary}");
    }
}

class PartTimeEmployee : Employee, IPayroll
{
    private int hours;
    private double rate;
    private double totalSalary;

    public PartTimeEmployee(int id, string empName, int h, double r) : base(id, empName)
    {
        hours = h;
        rate = r;
    }

    public void CalculateSalary()
    {
        totalSalary = hours * rate;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Type: Part-Time | Total Salary: {totalSalary}");
    }
}

class Program
{
    static void Main()
    {
        FullTimeEmployee ftEmp = new FullTimeEmployee(101, "Alice", 5000);
        ftEmp.CalculateSalary();
        ftEmp.Display();

        PartTimeEmployee ptEmp = new PartTimeEmployee(102, "Bob", 40, 20);
        ptEmp.CalculateSalary();
        ptEmp.Display();

        Console.ReadLine();
    }
}