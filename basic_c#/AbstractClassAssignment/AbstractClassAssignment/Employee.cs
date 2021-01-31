using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee : Person, IQuittable
    {
        public override void SayName(string firstName, string lastName) // inheritted method from Person
        {
            Console.WriteLine("Name: " + firstName + " " + lastName); // here's the implementation
        }
        public void Quit(Employee employee)
        {
            Console.WriteLine("Take this job and shove it.");
            Console.ReadLine();
        }
    }
}
