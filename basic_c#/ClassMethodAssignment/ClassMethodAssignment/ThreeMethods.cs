using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    public class ThreeMethods
    {
        public int Plus2(int num1)
        {
            int addResult = num1 + 2;
            Console.WriteLine(num1 + " plus 2, equals " + addResult);
            return addResult;
        }

        public int Times2(int num1)
        {
            int timesResult = num1 * 2;
            Console.WriteLine(num1 + " times two, equals " + timesResult);
            return timesResult;
        }

        public int Squared(int num1)
        {
            int squareResult = num1 * num1;
            Console.WriteLine(num1 + " times itelf, equals " + squareResult);
            return squareResult;
        }
    }
}
