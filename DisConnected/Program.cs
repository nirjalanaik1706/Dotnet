using System.Data;
using DisConnected;

public class Program
{
    public static void Main(string[] args)
    {

        StudentRepository repo=new StudentRepository();

        // repo.InsertStudents(new Student{First_name="Nirjala",Last_name="Naik",Email="nirjalanaik1706@gmail.com",Phone_no="7972520102"});

        repo.UpdateStudents(new Student{Id=1,First_name="Sahil",Last_name="Kamble",Email="sahilbajkamble@gmail.com",Phone_no="7972542628"});
        
        repo.DeleteStudent(2);
        var students=repo.GetStudents();
        foreach(DataRow row in students.Rows)
        {
            Console.WriteLine($"{row["Id"]}-{row["First_name"]}-{row["Last_name"]}-{row["Email"]}-{row["Phone_no"]}");
        }

    


    }
}
