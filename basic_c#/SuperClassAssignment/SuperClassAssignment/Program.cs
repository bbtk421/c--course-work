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
            //Employee employee = new Employee // instanciate
            //{
            //    FirstName = "Sample", // initialize
            //    LastName = "Student"
            //};

            //Employee employee1 = new Employee
            //{
            //    FirstName = "Temp",
            //    LastName = "Teacher"
            //};

            Employee<string> things = new Employee<string>(); // instanciate object
            things.Things = new List<string> // instaciate string list
            {
                "Manny", "Moe", "Jack"
            };

            Employee<int> stuff = new Employee<int>(); // instaciate object
            stuff.Things = new List<int> // instaciate int list
            {
                3, 6, 9
            };

            foreach (string s in things.Things) // loop through strings in list
            {
                Console.WriteLine(s);
                Console.ReadLine();
            }

            foreach (int i in stuff.Things) // loop through  ints in list
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }

            // employee.SayName(); // call method on object
            Console.ReadLine();

        }


    }
}

