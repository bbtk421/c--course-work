using System;
using System.Collections.Generic;

namespace ExceptionHandlingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = false; 
            do // makes the program run again after an exception instead of ending
            {
                try
                {
                    List<int> numList = new List<int>() { 2, 4, 6, 8, 10 };
                    Console.WriteLine("Please enter a whole number.");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    foreach (int i in numList)
                    {
                        int result = i / num1;
                        Console.WriteLine(result);
                    }
                    Console.ReadLine();
                    check = true;
                }
                catch (FormatException ex) // catched not an int
                {
                    Console.WriteLine("Please type a whole number.");
                }
                catch (DivideByZeroException ex) // catches zero
                {
                    Console.WriteLine("Please dont divide by zero...");
                }
                catch (Exception ex) // catches whatever else?
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.ReadLine();
                }
            }
            while (!check); // allows it to end if no exceptions
            Console.WriteLine("Try/Catch block finished.");
            Console.ReadLine();
        }
    }
}