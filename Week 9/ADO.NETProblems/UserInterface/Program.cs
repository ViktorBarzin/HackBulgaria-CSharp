using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    using System.Data.SqlClient;
    using System.Globalization;

    using HackCompany;

    class Program
    {
        static void Main(string[] args)
        {
            // TODO : Code reuse on queries?
            // TODO : Remove magic string from queries
            string connectionString = ConfigurationManager.ConnectionStrings["HackCompany"].ConnectionString;
            DbCommunication.Insert(connectionString, new Category("ABC", "abc"));

            //string query = @"SELECT TOP 10 *
            //                FROM HackCompany.dbo.Customer c
            //                WHERE c.Id=2";

            //using (var connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    var command = new SqlCommand(query, connection);

            //    using (var reader = command.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            string name = StringOrNull(reader["Name"]);
            //            string email = StringOrNull(reader["Email"]);
            //            Console.WriteLine(string.Format(name + email));
            //        }
            //    }
            //}

        }

        private static string StringOrNull(object value)
        {
            if (value is DBNull)
            {
                return null;
            }
            return (string)value;
        }
    }
}
