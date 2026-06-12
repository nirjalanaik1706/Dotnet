namespace SalesManager;

using System.Numerics;
using Employee;
using SalesEmployee;

public class SalesManager : SalesEmployee, Employee
{
    public double Bonus;

    public SalesManager()
    {
        Bonus = 0;
    }

    public SalesManager(double Salary, double Insentive, double Hra, double Bonus) : base(Salary, Insentive, Hra)
    {
        this.Salary = Salary;
        this.Insentive = Insentive;
        this.Hra = Hra;
        this.Bonus = Bonus;
    }

    public double ComputePay()
    {
        double TotalSalaryManager = base.ComputePay() + Bonus;
        Console.WriteLine($"Total salary of SalesManager: {TotalSalaryManager} ");
        return 0;
    }

}