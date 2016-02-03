namespace HackCompany
{
    using System;
    using System.Data.SqlClient;


    public class DbConnection
    {
        private readonly string connectionString;

        public DbConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool Insert(Category category)
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                string query = @"SELECT count(*) FROM Category c WHERE c.Code='" + category.Code + "'";
                var command = new SqlCommand(query, connection);
                int rows = (int)command.ExecuteScalar();

                if (rows == 1)
                {

                    string updateQuery = @"UPDATE Category SET Name='" + category.Name
                                         + "' WHERE Category.Code='" + category.Code + "'";
                    var updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.ExecuteNonQuery();
                    return true;
                }
                else if (rows == 0)
                {
                    string insertQuery = @"INSERT INTO Category (Code,Name)
                                            VALUES ('" + category.Code + "','" + category.Name + "')";
                    var insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.ExecuteNonQuery();
                    return true;
                }

                return false;
            }
        }

        public bool Insert(Customer customer)
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                string query = @"SELECT count(*) FROM Customer c WHERE c.Id='" + customer.Id + "'";
                var command = new SqlCommand(query, connection);
                int rows = (int)command.ExecuteScalar();

                if (rows == 1)
                {
                    string discount = customer.Discount?.ToString();
                    if (discount == null)
                    {
                        discount = "NULL";
                    }

                    string updateQuery =
                        string.Format(
                            "UPDATE Customer SET Name='{0}',Email='{1}', Address='{2}', Discount={3} WHERE Id={4}",
                            customer.Name,
                            customer.Email,
                            customer.Email,
                            discount,
                            customer.Id);
                    var updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.ExecuteNonQuery();
                    return true;
                }
                else if (rows == 0)
                {
                    string discount = customer.Discount?.ToString();
                    if (discount == null)
                    {
                        discount = "NULL";
                    }

                    string insertQuery = string.Format(
                        "INSERT INTO Customer VALUES('{0}','{1}','{2}',{3})",
                        customer.Name,
                        customer.Email,
                        customer.Address,
                        discount);
                    var insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.ExecuteNonQuery();
            customer.Id = this.GetLastId("Customer");
                }
            }

            return true;
        }

        private int GetLastId(string tableName)
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                string lastId = string.Format("SELECT TOP 1 IDENT_CURRENT('{0}')", tableName);
                var getLastId = new SqlCommand(lastId, connection);
                return Convert.ToInt32(getLastId.ExecuteScalar());
            }
        }

        private string StringOrNull(object value)
        {
            if (value is DBNull)
            {
                return null;
            }
            return (string)value;
        }
    }
}