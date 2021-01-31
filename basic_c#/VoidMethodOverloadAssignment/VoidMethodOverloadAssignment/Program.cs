using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodOverloadAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            vMath math1 = new vMath();
            Console.WriteLine("Please privide a whole number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = 3;

            math1.Maths(num1);
            math1.Maths(num1, num2, out int x);
            Console.ReadLine();

            int num3 = 10;
            Class1.sMath(num1, num3);
            Console.ReadLine();
        }
    }
}
