using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Student_Management_System
{
    public class DBConnect
    {

        private readonly SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        public SqlConnection GetConnection()
        {
            return connection;
        }

        public void Open()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        public void Close()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
    }
}