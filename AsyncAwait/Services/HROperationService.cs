using AsyncAwait;
using System;


namespace HRService;

public class HROperationService
{
    public async Task<List<Employee>> GetEmployeesAsync()
    {
        await Task.Delay(2000);

        return new List<Employee>
        {
            new Employee{Id=101, Name="Nirjala", Department="IT",Salary=50000},
            new Employee{Id=101, Name="Sahil", Department="IT",Salary=50000},
            new Employee{Id=101, Name="Saya", Department="IT",Salary=50000},
            new Employee{Id=101, Name="Niru", Department="IT",Salary=50000}
        };
    }

    public async Task<double>  CalculateBonus(Employee emp)
    {
        await Task.Delay(5000);
        return emp.Salary*0.30;
    }

    public async Task SaveEmployeeAsync(Employee emp)
    {
        await Task.Delay(5000);
        Console.WriteLine($"Employee saved automatically: {emp.Name}");
    }
}