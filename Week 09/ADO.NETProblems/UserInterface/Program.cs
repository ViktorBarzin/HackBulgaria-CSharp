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
            // TODO : finish when ADO.NET gets useful if ever does
            string connectionString = ConfigurationManager.ConnectionStrings["HackCompany"].ConnectionString;
            DbConnection dbConnection = new DbConnection(connectionString);
            Category category = new Category("TST","NETEST");
            dbConnection.Insert(category);

            //var c1 = new Product(1,"prod 1",100,"SFT");
            //dbConnection.Insert(c1);

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
    }
}
