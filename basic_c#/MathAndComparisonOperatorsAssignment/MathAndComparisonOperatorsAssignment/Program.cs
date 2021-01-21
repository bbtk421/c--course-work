using System;


namespace MathAndComparisonOperatorsAssignment
{
    class Program
    {
        static void Main()
        {
            // title
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            // person 1 inputs
            Console.WriteLine("Person 1:\nWhat is your hourly pay rate?");
            double person1Pay = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many hours do you work a week?");
            double person1Hours = Convert.ToDouble(Console.ReadLine());
            // person 2 inputs
            Console.WriteLine("Person 2:\nWhat is your hourly pay rate?");
            double person2Pay = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many hours do you work a week?");
            double person2Hours = Convert.ToDouble(Console.ReadLine());
            // annual salary person 1
            double person1Annual = person1Pay * person1Hours * 52.0;
            Console.WriteLine("Person 1 makes " + person1Annual + " a year.");
            Console.ReadLine();
            // annual salary person 2
            double person2Annual = person2Pay * person2Hours * 52.0;
            Console.WriteLine("Person 2 makes " + person2Annual + " a year.");
            Console.ReadLine();
            // compare annual salaries
            bool salaryCompare = person1Annual > person2Annual;
            Console.WriteLine("Does person 1 make more money per year than person 2?\n" + salaryCompare);
            Console.ReadLine();

        }
    }
}
