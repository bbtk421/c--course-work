using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); // instanciating object
            employee.SayName("Sample", "Student"); // with these values
            Console.ReadLine();
            employee.Quit(employee);

        }

    }
}
