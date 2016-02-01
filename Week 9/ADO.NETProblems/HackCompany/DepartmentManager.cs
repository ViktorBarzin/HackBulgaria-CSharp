namespace HackCompany
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DepartmentManager
    {
        public DepartmentManager(int departmentId, int managerId)
        {
            this.DepartmentId = departmentId;
            this.ManagerId = managerId;
        }

        public int DepartmentId { get; set; }

        public int ManagerId { get; set; }
    }
}
