using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

public class ConnectionService
{
    public readonly SqlConnection? cn;

    public ConnectionService()
    {
        string connectionString = "server=(local);database=manage-rent-bike;Integrated Security=True";

        try
        {
            SqlConnection connection = new SqlConnection(connectionString);
            this.cn = connection;
            // Thực hiện các thao tác với cơ sở dữ liệu ở đây
        }
        catch (Exception e)
        {
            Console.WriteLine("", e.ToString());
        }
    }

}

