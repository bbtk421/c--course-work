using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            voidMath math1 = new voidMath();
            math1.Maths(4, 5);
            math1.Maths(num1: 3, num2: 6);
            Console.ReadLine();

        }
    }
}
