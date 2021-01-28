using System;

class Program
    {
        static void Main(string[] args)
        {
		bool check = false;
		do
		{
			try
			{
				Console.WriteLine("Pick a number.");
				int numberOne = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Pick a second number.");
				int numberTwo = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Dividing the two...");
				int numberThree = numberOne / numberTwo;
				Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree + ".");
				Console.ReadLine();
				check = true;
			}
			catch (FormatException ex)
			{
				Console.WriteLine("Please type a whole number."); // this would need to save the new input
			}
			catch (DivideByZeroException ex)
			{
				Console.WriteLine("Please don't divide by zero..."); // this would need to save the new inpu
			}
			catch (Exception ex) // this would need to save the new input
			{
				Console.WriteLine(ex.Message);
			}
			finally // can be used to log exceptions
			{
				Console.ReadLine();
			}
		}
		while (!check);
        }
    }

