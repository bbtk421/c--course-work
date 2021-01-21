using System;

namespace BranchingAssignment
{
    class Program
    {
        static void Main()
        {
            // greeting
            Console.WriteLine("Welcome to Package Express. \nPlease folow the instructions below.");
            Console.ReadLine();

            // user input weight
            Console.WriteLine("How much does your package weigh?");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)  // kick out if too heavy
            {
                Console.WriteLine("Your package is too heavy to be shipped via Package Express. Have a nice day.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            else
            {
                Console.ReadLine(); // if not then continue
            }

            // user input package dimensions
            Console.WriteLine("Please enter your package width:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your package height:");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            if (width + height + length > 50) // kick out if it's too big
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a nice day!");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            else // shipping calculation
            {
                double total = ((width * height * length) * (weight)) / 100.00;
                Console.WriteLine("Your esitmated shipping total is: $" + total + "\nThank you!");
                Console.ReadLine();
            }
        }
    }
}
