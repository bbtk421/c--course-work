using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            ThreeMethods methods = new ThreeMethods();
            Console.WriteLine("Please provide a whole number.");
            int num1 = Convert.ToInt32(Console.ReadLine());

            methods.Plus2(num1);
            Console.ReadLine();

            methods.Times2(num1);
            Console.ReadLine();

            methods.Squared(num1);
            Console.ReadLine();

        }
    }
}
