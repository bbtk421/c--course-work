using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose today's day of the week(capitalize please).");
            bool daysCorrect = false;
            while (daysCorrect == false)
            {
                try
                {
                    Enum.Days day = (Enum.Days)Enum.Days.Parse(typeof(Enum.Days), Console.ReadLine());
                    Console.WriteLine("So today is " + day + ", good to know.");
                    daysCorrect = true;
                }
                catch
                {
                    Console.WriteLine("Please pick an actual day of the week.");
                }
            }
            Console.ReadLine();
        }
    }
}
