using System;


class Program
{
    static void Main()
    {
        // write to console and have it stay
        Console.WriteLine("Hello, \"World!\"");
        Console.ReadLine();

        // math challenges
        int num1 = 11;
        int num2 = 2;
        int totalAdd = num1 + num2;
        Console.WriteLine(totalAdd);
        Console.ReadLine();

        int totalSub = num2 - num1;
        Console.WriteLine(totalSub);
        Console.ReadLine();

        int totalMult = num1 * num2;
        Console.WriteLine(totalMult);
        Console.ReadLine();

        double totalDiv = (double)num2 / num1;
        Console.WriteLine(totalDiv);
        Console.ReadLine();
    }
}

