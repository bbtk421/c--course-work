using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main()
        {
            // && AND operator
            Console.WriteLine(true && false);
            Console.WriteLine(true && true);
            Console.WriteLine(false && false);
            Console.ReadLine();
            // || OR operator
            Console.WriteLine(true || false);
            Console.WriteLine(true || true);
            Console.WriteLine(false || false);
            Console.ReadLine();
            // == EQUALS operator
            Console.WriteLine(true == false);
            Console.WriteLine(true == true);
            Console.WriteLine(false == false);
            Console.ReadLine();
            // != NOT EQUAL operator
            Console.WriteLine(true != false);
            Console.WriteLine(true != true);
            Console.WriteLine(false != false);
            Console.ReadLine();
            // ^ XOR operator(one is true but not both)
            Console.WriteLine(true ^ false);
            Console.WriteLine(true ^ true);
            Console.WriteLine(false ^ false);
            Console.ReadLine();
        }
    }
}
