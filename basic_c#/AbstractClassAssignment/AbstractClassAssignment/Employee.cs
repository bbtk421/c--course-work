using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee : Person
    {
        public override void SayName(string firstName, string lastName) // inheritted method from Person
        {
            Console.WriteLine("Name: " + firstName + " " + lastName); // here's the implimentation
        }
    }
}
