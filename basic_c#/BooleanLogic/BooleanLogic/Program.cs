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
			// nested statements
			int num1 = 7;
			if (num1 < 18 && ((num1==7) || num1==2) && ((num1==8 && num1 > 20) || (num1 < 20 && num1 > 2)))
			{
				Console.WriteLine("Did you get all that?");
			}
        }
    }
}
