using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemnt
{
    internal class StudentManagementSystem
    {
        public List<Teacher> Teachers { get; set; } = new List<Teacher>(); // List to store teachers
        public List<Student> Students { get; set; } = new List<Student>(); // List to store students
        public List<Department> Departments { get; set; } = new List<Department>(); // List to store departments
        public List<Course> Courses { get; set; } = new List<Course>(); // List to store courses
        public List<Subject> Subjects { get; set; } = new List<Subject>(); // List to store subjects

        // Method to add a teacher to the system
        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }

        // Method to add a student to the system
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        // Method to add a department to the system
        public void AddDepartment(Department department)
        {
            Departments.Add(department);
        }

        // Method to add a course to the system
        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        // Method to add a subject to the system
        public void AddSubject(Subject subject)
        {
            Subjects.Add(subject);
        }
    }
}

