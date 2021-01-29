using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            MathMethods methods = new MathMethods();
            int num2 = 4;
            int num3 = 5;
            Console.WriteLine("Please provide a whole number.");
            int num1 = Convert.ToInt32(Console.ReadLine());

            methods.Math(num1);
            Console.ReadLine();

            methods.Math(num1, num2);
            Console.ReadLine();

            methods.Math(num1, num2, num3);
            Console.ReadLine();
        }
    }
}
