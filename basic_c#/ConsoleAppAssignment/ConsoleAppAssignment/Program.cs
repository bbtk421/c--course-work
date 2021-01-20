using System;


namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main()
        {
            // get user number
            Console.WriteLine("Please provide a whole number:");
            int faveNum = Convert.ToInt32(Console.ReadLine());
            // time 50
            int totalMult = faveNum * 50;
            Console.WriteLine(faveNum + " times 50 = " + totalMult);
            Console.ReadLine();
            // add 25
            int totalAdd = faveNum + 25;
            Console.WriteLine(faveNum + " plus 25 = " + totalAdd);
            Console.ReadLine();
            // divide by 12.5f
            double totalDiv = faveNum / 12.5d;
            Console.WriteLine(faveNum + " divded by 12.5 = " + totalDiv);
            Console.ReadLine();
            // greater than 50?
            bool totalGreater = faveNum > 50;
            Console.WriteLine(faveNum + " is greater than 50? = " + totalGreater);
            Console.ReadLine();
            // divided by 7 with remainder
            int totalRemainder = faveNum % 7;
            Console.WriteLine("When you divide " + faveNum + " by 7, the remainder is " + totalRemainder + ("."));
            Console.ReadLine();
        }
    }
}
