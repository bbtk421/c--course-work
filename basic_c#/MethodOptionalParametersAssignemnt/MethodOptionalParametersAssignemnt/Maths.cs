using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOptionalParametersAssignemnt
{
    public class Maths
    {
        public int Math(int num1, int num2 = 1)
        {
            int result = (num1 + num2) * 2;
            Console.WriteLine(num1 + " plus " + num2 + " times 2, equals " + result);
            return result;
        }
    }
}
