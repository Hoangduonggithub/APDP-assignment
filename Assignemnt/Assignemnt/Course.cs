using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignemnt
{
    internal class Course
    {
        public string Name { get; set; } // Property to store the name of the course
        public string CourseCode { get; set; } // Property to store the course code
        public Department Department { get; set; } // Property to store the department offering the course
        public List<Subject> Subjects { get; set; } = new List<Subject>(); // List to store subjects related to the course
    }
}
