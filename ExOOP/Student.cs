using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOOP
{
    public class Student : Person
    {
        public string StudentId { get; set; }
        public float GPA { get; set; }
        public override void Input()
        {
            Console.Write("Name of Student: ");
            Name = Console.ReadLine();
            Console.Write("Age of Student: ");
            Age = int.Parse(Console.ReadLine());
            Console.Write("Student ID: ");
            StudentId = Console.ReadLine();
            Console.Write("GPA: ");
            GPA = float.Parse(Console.ReadLine());
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Name of Student: " + Name);
            Console.WriteLine("Age of Student: " + Age);
            Console.WriteLine("Student ID: " + StudentId);
            Console.WriteLine("GPA: " + GPA);
        }
    }
}
