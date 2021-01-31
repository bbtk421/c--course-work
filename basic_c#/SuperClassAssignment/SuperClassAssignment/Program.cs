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

            employee.SayName(); // call method on object
            Console.ReadLine();
        }
    }
}
