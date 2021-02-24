using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssignemnt2
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool validAge = false;
            while (!validAge)
            {
                try
                {
                    Console.WriteLine("How old are you?");
                    int age = Convert.ToInt32(Console.ReadLine());
                    if (age <= 0)
                    {
                        throw new Exception();
                    }
                    DateTime now = DateTime.Now;
                    DateTime birthYear = now.AddYears(-age);
                    int year = birthYear.Year;
                    Console.WriteLine("So, you were born in " + year + "...");
                    Console.ReadLine();
                    validAge = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a positive number, not zero, no decimals.");
                    Console.ReadLine();
                    validAge = false;
                }
            }
        }
    }
}
