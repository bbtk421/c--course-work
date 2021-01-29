using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment2
{
    public class MathMethods
    {
        public int Math(int num1)
        {
            int result = num1 + 2;
            Console.WriteLine(num1 + " plus 2, equals " + result);
            return result;
        }

        public int Math(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine(num1 + " times " + num2 + ", equals " + result);
            return result;
        }

        public int Math(int num1, int num2, int num3)
        {
            int result = num1 - num2 + num3;
            Console.WriteLine(num1 + " minus " + num2 + " plus " + num3 + ", equals " + result);
            return result;
        }
    }
}
