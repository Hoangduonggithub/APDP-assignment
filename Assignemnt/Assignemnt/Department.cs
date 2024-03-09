using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemnt
{
    internal class Department
    {
        public string Name { get; set; } // Property to store the name of the department
        public string DepartmentId { get; set; } // Property to store the department ID
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
