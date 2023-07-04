using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOOP
{
    public class Teacher : Person
    {
        public string TeacherId { get; set; }
        public string Subject { get; set; }

        public override void Input()
        {
            Console.Write("Name of Teacher: ");
            Name = Console.ReadLine();
            Console.Write("Age of Teacher: ");
            Age = int.Parse(Console.ReadLine());
            Console.Write("Teacher ID: ");
            TeacherId = Console.ReadLine();
            Console.Write("Subject: ");
            Subject = Console.ReadLine();
        }
    }
}
