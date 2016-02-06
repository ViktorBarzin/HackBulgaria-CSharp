namespace HackCompany
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Employee
    {
        public Employee(int id, string name, string email, DateTime dateOfBirth, int? managerId, int? departmentId)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.DateOfBirth = dateOfBirth;
            this.ManagerId = managerId;
            this.DepartmentId = departmentId;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int? ManagerId { get; set; }

        public int? DepartmentId { get; set; }
    }
}
