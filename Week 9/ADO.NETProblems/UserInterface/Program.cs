using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    using System.Data.SqlClient;

    class Program
    {
        static void Main(string[] args)
        {
            // TODO : Check how connection works
            string connectionString = ConfigurationManager.ConnectionStrings["HackCompany"].ConnectionString;
            string query = @"SELECT TOP 1 *
                            FROM HackCompany.dbo.Customer";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand(query, connection);
                string res = (string)command.ExecuteScalar();
                Console.WriteLine(res);
            }

        }
    }
}
