using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoggingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a number."); // ask user for the number
            string number = Console.ReadLine(); // saves as variable
            File.WriteAllText(@"C:\Users\bbtk4\Documents\GitHub\c--course-work\basic_c#\LoggingAssignment\LoggingAssignment\log.txt", number);//  writes input to file and creates if needed
            Console.WriteLine(File.ReadAllText(@"C:\Users\bbtk4\Documents\GitHub\c--course-work\basic_c#\LoggingAssignment\LoggingAssignment\log.txt")); // prints the file to console
            Console.ReadLine();
        }
    }
}
