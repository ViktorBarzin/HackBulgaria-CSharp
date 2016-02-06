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

        public bool Insert(Department department)
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                string query = @"SELECT count(*) FROM Departament c WHERE c.Id='" + department.Id + "'";
                var command = new SqlCommand(query, connection);
                int rows = (int)command.ExecuteScalar();

                if (rows == 1)
                {
                    string updateQuery =
                        string.Format(
                            "UPDATE Departament SET Name='{0} 'WHERE Id={1}",
                            department.Name,
                            department.Id);
                    var updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.ExecuteNonQuery();
                    return true;
                }
                else if (rows == 0)
                {
                    string insertQuery = string.Format(
                        "INSERT INTO Departament VALUES('{0}')",
                        department.Name);
                    var insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.ExecuteNonQuery();
                    department.Id = this.GetLastId("Departament");
                }
            }

            return true;
        }

        public bool Insert(Employee employee)
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                string query = @"SELECT count(*) FROM Employee c WHERE c.Id='" + employee.Id + "'";
                var command = new SqlCommand(query, connection);
                int rows = (int)command.ExecuteScalar();

                if (rows == 1)
                {
                    string managerId = employee.ManagerId?.ToString();
                    if (employee.ManagerId == null)
                    {
                        managerId = "NULL";
                    }

                    string departmentId = employee.DepartmentId?.ToString();
                    if (employee.DepartmentId == null)
                    {
                        departmentId = "NULL";
                    }
                    var birthDate = employee.DateOfBirth.Date.ToString("yyyyMMdd HH:mm:ss");
                    string updateQuery =
                        string.Format(
                            "UPDATE Employee SET Name='{0}',Email='{1}', DateOfBirth='{2}', ManagerId={3}, DepartamentId={4} WHERE Id={5}",
                            employee.Name,
                            employee.Email,
                            birthDate,
                            managerId,
                            departmentId,
                            employee.Id);
                    var updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.ExecuteNonQuery();
                    return true;
                }
                else if (rows == 0)
                {
                    string managerId = employee.ManagerId?.ToString();
                    if (employee.ManagerId == null)
                    {
                        managerId = "NULL";
                    }

                    string departmentId = employee.DepartmentId?.ToString();
                    if (employee.DepartmentId == null)
                    {
                        departmentId = "NULL";
                    }

                    string insertQuery = string.Format(
                        "INSERT INTO Employee VALUES('{0}','{1}','{2}',{3}, {4})",
                        employee.Name,
                        employee.Email,
                        employee.DateOfBirth,
                        managerId,
                        departmentId);
                    var insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.ExecuteNonQuery();
                    employee.Id = this.GetLastId("Employee");
                }
            }

            return true;
        }

        public bool Insert(Order order)
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                string query = @"SELECT count(*) FROM [Order] c WHERE c.Id='" + order.Id + "'";
                var command = new SqlCommand(query, connection);
                int rows = (int)command.ExecuteScalar();

                if (rows == 1)
                {
                    string formattedDate = order.Date.ToString("yyyyMMdd HH:mm:ss");
                    string updateQuery =
                        string.Format(
                            "UPDATE [Order] SET Date='{0}',CustomerId='{1}', totalPrice='{2}' WHERE Id={3}",
                            formattedDate,
                            order.CustomerId,
                            order.TotalPrice,
                            order.Id);
                    var updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.ExecuteNonQuery();
                    return true;
                }
                else if (rows == 0)
                {
                    string formattedDate = order.Date.ToString("yyyyMMdd HH:mm:ss");
                    string insertQuery = string.Format(
                        "INSERT INTO [Order] VALUES('{0}','{1}','{2}')",
                        formattedDate,
                        order.CustomerId,
                        order.TotalPrice);
                    var insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.ExecuteNonQuery();
                    order.Id = this.GetLastId("[Order]");
                }
            }

            return true;
        }

        public bool Insert(Product product)
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                string query = @"SELECT count(*) FROM Product c WHERE c.Id='" + product.Id + "'";
                var command = new SqlCommand(query, connection);
                int rows = (int)command.ExecuteScalar();

                if (rows == 1)
                {
                    string updateQuery =
                        string.Format(
                            "UPDATE Product SET Name='{0}',singlePrice='{1}', Category='{2}' WHERE Id={3}",
                            product.Name,
                            product.Price,
                            product.Category,
                            product.Id);
                    var updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.ExecuteNonQuery();
                    return true;
                }
                else if (rows == 0)
                {
                    string insertQuery = string.Format(
                        "INSERT INTO Product VALUES('{0}','{1}','{2}',{3})",
                        product.Name,
                        product.Price,
                        product.Category);
                    var insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.ExecuteNonQuery();
                    product.Id = this.GetLastId("Product");
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