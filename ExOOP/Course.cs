using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOOP
{
    public class Course : Person
    {
        public string CourseName { get; set; }
        public Teacher Instructor { get; set; }
        public List<Student> Students { get; set; }

        public Course(string name, Teacher instructor)
        {
            CourseName = name;
            Instructor = instructor;
            Students = new List<Student>();
        }

        public override void PrintInfo()    
        {
            Console.WriteLine("Course Name: " + CourseName);
            Console.WriteLine("Instructor: " + Instructor.Name);
            Console.WriteLine("Number of Students: " + Students.Count);
        }
    }
}
