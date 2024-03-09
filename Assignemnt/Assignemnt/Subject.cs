using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemnt
{
    internal class Subject
    {
        public string Name { get; set; } // Property to store the name of the subject
        public string SubjectCode { get; set; } // Property to store the subject code
        public Course Course { get; set; } // Property to store the course associated with the subject
    }
}
