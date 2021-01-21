using System;

namespace IfElseStatements
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your name?(lowercase please)");
            string name = Console.ReadLine();
            if (name == "brian")
            {
                Console.WriteLine("Your name is " + name + ", that is a cool name!");
                Console.ReadLine();
            }
            else if (name == "bryan")
            {
                Console.WriteLine("Your name is " + name + ", it would be cool, if you spelled it right...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your name is " + name + ", this is not a cool name.");
                Console.ReadLine();
            }
            //int num1 = 9;
            //int num2 = 11;

            //string result = num1 < num2 ? "num1 is less than num2" : "num1 is not less than num2";
            //Console.WriteLine(result);
            //Console.ReadLine();
        }
    }
}
