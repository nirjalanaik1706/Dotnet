using System.Data;
using DisConnected;

public class Program
{
    public static void Main(string[] args)
    {
        var repo=new ProductRepository();
        var students=repo.GetStudents();
        foreach(DataRow row in students.Rows)
        {
            Console.WriteLine($"{row["Id"]}-{row["First_name"]}-{row["Last_name"]}-{row["Email"]}-{row["Phone_no"]}");
        }
    }
}
