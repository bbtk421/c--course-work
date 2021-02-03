using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee // instanciate
            {
                FirstName = "Sample", // initialize
                LastName = "Student"
            };

            Employee employee1 = new Employee
            {
                FirstName = "Temp",
                LastName = "Teacher"
            };

            employee.SayName(); // call method on object
            Console.ReadLine();

        }


    }
}

