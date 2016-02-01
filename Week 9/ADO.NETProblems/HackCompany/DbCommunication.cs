namespace HackCompany
{
    using System;
    using System.Data.SqlClient;


    public class DbCommunication
    {
        public bool Insert(string connectionString, Category category)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT count(*) FROM  HackCompany.dbo.Category c WHERE c.Code='" + category.Code + "'";
                var command = new SqlCommand(query, connection);
                int rows = (int)command.ExecuteScalar();

                if (rows == 1)
                {

                    string updateQuery = @"UPDATE HackCompany.dbo.Category SET Name='" + category.Name
                                         + "' WHERE HackCompany.dbo.Category.Code='" + category.Code + "'";
                    var updateCommand = new SqlCommand(updateQuery, connection);
                    var res = updateCommand.ExecuteNonQuery();
                    return true;
                }
                else if (rows == 0)
                {
                    Console.WriteLine("asda");
                    string insertQuery = @"INSERT INTO HackCompany.dbo.Category (Code,Name)
                                            VALUES ('" + category.Code + "','" + category.Name + "')";
                    var insertCommand = new SqlCommand(insertQuery, connection);
                    var res = insertCommand.ExecuteNonQuery();
                    return true;
                }

                return false;
            }
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