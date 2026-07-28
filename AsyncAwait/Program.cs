using AsyncAwait;
using HRService;
using System;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("HR System Started");
        HROperationService hr=new HROperationService();

        var employees=await hr.GetEmployeesAsync();
        Console.WriteLine("Employee Loaded");
        employees.ForEach(e=>Console.WriteLine(e));

        Console.WriteLine("\nCalculating bonus asynchronously...");
        double bonus=await hr.CalculateBonus(employees[0]);
        Console.WriteLine($"Bonus for {employees[0].Name}:{bonus}");

        await hr.SaveEmployeeAsync(employees[0]);
        Console.WriteLine("\nHR System Completed");
    }
}