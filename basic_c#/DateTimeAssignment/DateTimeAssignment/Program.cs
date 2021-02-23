using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a positive whole number."); // asks for input
            int hours = Convert.ToInt32(Console.ReadLine()); // saves input

            DateTime now = DateTime.Now; //defines now as the current time
            DateTime future = now.AddHours(hours); // adds the user input amount of hours to the current time and saves as a new varible

            Console.WriteLine("In " + hours + " hours, the time will be " + future + ".");
            Console.ReadLine();
        }
    }
}
