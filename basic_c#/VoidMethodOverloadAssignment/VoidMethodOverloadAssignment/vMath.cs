using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodOverloadAssignment
{
    public class vMath
    {
        public void Maths(int num1)
        {
            int result = num1 / 2;
            Console.WriteLine(result);
        }
        public void Maths(int num1, int num2, out int x)
        {
            x = num1 / num2;
            Console.WriteLine(x);
        }
    }
}
