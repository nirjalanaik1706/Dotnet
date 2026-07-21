namespace DisConnected;

using System.Data;
using MySql.Data.MySqlClient;

public class StudentRepository
{
    private  string connectionString = "Server=localhost;Database=tflstudentdb;UserId=root;Password=password";
    private MySqlDataAdapter GetDataAdapter(MySqlConnection connection)
    {
        var selectCommand=new MySqlCommand("select * from students",connection);
        var adapter=new MySqlDataAdapter(selectCommand);
        new MySqlCommandBuilder(adapter);
        return adapter;
    }


    public DataTable GetStudents()
    {
        using var connection=new MySqlConnection(connectionString);
        var adapter=GetDataAdapter(connection);
        var table=new DataTable();
        adapter.Fill(table);
        return table;
    }

    public void InsertStudents(Student students)
    {
        using var connection=new MySqlConnection(connectionString);
        var adapter=GetDataAdapter(connection);

        var table=new DataTable();
        adapter.Fill(table);

        var NewRow=table.NewRow();
        NewRow["First_name"]=students.First_name;
        NewRow["Last_name"]=students.Last_name;
        NewRow["Email"]=students.Email;
        NewRow["Phone_no"]=students.Phone_no;
        table.Rows.Add(NewRow);

        adapter.Update(table);
    }

    public void UpdateStudents(Student student)
    {
        using var connection=new MySqlConnection(connectionString);
        var adapter=GetDataAdapter(connection);

        var table=new DataTable();
        adapter.Fill(table);

        var Rows=table.Select($"Id={student.Id}");
        if (Rows.Length > 0)
        {
            Rows[0]["First_name"]=student.First_name;
            Rows[0]["Last_name"]=student.Last_name;
            Rows[0]["Email"]=student.Email;
            Rows[0]["Phone_no"]=student.Phone_no;
            adapter.Update(table);
            
        }
    }

    public void DeleteStudent(int studentId)
    {
        using var connection=new MySqlConnection(connectionString);
        var adapter=GetDataAdapter(connection);
        var table=new DataTable();
        adapter.Fill(table);

        var Rows=table.Select($"Id={studentId}");
        if (Rows.Length > 0)
        {
            Rows[0].Delete();
            adapter.Update(table);
        }
    }

}