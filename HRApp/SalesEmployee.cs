namespace SalesEmployee;

using Employee;

public class SalesEmployee : Employee
{
    public double Salary;
    public double Insentive;
    public double Hra;

    public SalesEmployee()
    {
        Salary = 0;
        Insentive = 0;
        Hra = 0;
    }

    public SalesEmployee(double Salary, double Insentive, double Hra)
    {
        this.Salary = Salary;
        this.Insentive = Insentive;
        this.Hra = Hra;
    }
    public double ComputePay()
    {
        double TotalSalary = Salary + Insentive + Hra;
        Console.WriteLine($"Total salary of the Sales Employee: {TotalSalary}");
        return 0;
    }
}