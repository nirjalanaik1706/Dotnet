namespace DisConnected;

using System.Data;
using MySql.Data.MySqlClient;

public class ProductRepository
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
}