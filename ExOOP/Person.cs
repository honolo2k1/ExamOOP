using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOOP
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Input()
        {
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Age: ");
            Age = int.Parse(Console.ReadLine());
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }
}
