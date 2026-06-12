namespace HR;
using Employee;
using SalesEmployee;
using SalesManager;

public class Program{
    public static void Main(string[] args)
    {
        // SalesEmployee employee=new SalesEmployee(90000,1000,200);
        SalesManager manager=new SalesManager(10000,200,2,900);

        // employee.ComputePay();
        manager.ComputePay();

    }
}