using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemnt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Code for initializing the student management system, adding data, and performing operations    
            var sms = new StudentManagementSystem();

            // Adding departments
            var itDepartment = new Department { Name = "IT", DepartmentId = "IT001" };
            sms.AddDepartment(itDepartment);

            // Adding courses
            var pythonCourse = new Course { Name = "Python Programming", CourseCode = "PY101", Department = itDepartment };
            sms.AddCourse(pythonCourse);

            // Adding subjects
            var pythonSubject = new Subject { Name = "Introduction to Python", SubjectCode = "PY10101", Course = pythonCourse };
            sms.AddSubject(pythonSubject);

            // Adding teachers
            var pythonTeacher = new Teacher { Name = "John Doe", Age = 35, Email = "john@example.com", Department = "IT" };
            sms.AddTeacher(pythonTeacher);

            // Adding students
            var student1 = new Student { Name = "Alice", Age = 20, Email = "alice@example.com", StudentId = "S001" };
            sms.AddStudent(student1);

            // Listing students
            Console.WriteLine("List of Students:");
            foreach (var student in sms.Students)
            {
                Console.WriteLine($"Name: {student.Name}, Student ID: {student.StudentId}");
            }

            // Listing teachers
            Console.WriteLine("\nList of Teachers:");
            foreach (var teacher in sms.Teachers)
            {
                Console.WriteLine($"Name: {teacher.Name}, Department: {teacher.Department}");
            }

            // Listing departments
            Console.WriteLine("\nList of Departments:");
            foreach (var department in sms.Departments)
            {
                Console.WriteLine($"Department: {department.Name}");
            }

            // Listing courses
            Console.WriteLine("\nList of Courses:");
            foreach (var course in sms.Courses)
            {
                Console.WriteLine($"Course: {course.Name}, Department: {course.Department.Name}");
            }

            // Listing subjects
            Console.WriteLine("\nList of Subjects:");
            foreach (var subject in sms.Subjects)
            {
                Console.WriteLine($"Subject: {subject.Name}, Course: {subject.Course.Name}");
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
