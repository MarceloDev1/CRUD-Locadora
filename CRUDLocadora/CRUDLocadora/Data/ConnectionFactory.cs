using Microsoft.Data.SqlClient;

namespace CRUDLocadora.Data
{
    public class ConnectionFactory
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=Locadora;User ID=acsadmin;Password=UXC0m3x0217;TrustServerCertificate=True;";
            return new SqlConnection(connectionString);
        }
    }
}