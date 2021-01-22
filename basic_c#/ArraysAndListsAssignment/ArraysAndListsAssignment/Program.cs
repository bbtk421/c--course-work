using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // string array with user choice
        string[] stringArray = { "Hello, ", "my", "name", "is", "Inigo", "Montoya." };// for PB fans
        Console.WriteLine("Pick a number between 0 & 5.(0 & 5 are ok)");
        int stringChoice = Convert.ToInt32(Console.ReadLine());

        if (stringChoice > 5) // nothing higher than 5
        {
            Console.WriteLine("Please select a new number and keep it between 0 & 5 this time...");
            stringChoice = Convert.ToInt32(Console.ReadLine()); // saves new input to our variable
        }
        else if (stringChoice < 0) // nothing less than 0
        {
            Console.WriteLine("Please select a new number and keep it between 0 & 5 this time...");
            stringChoice = Convert.ToInt32(Console.ReadLine()); // saves new input to our variable
        }
        else // runs whats after this if you chose a valid index
        {
        }
        Console.WriteLine(stringArray[stringChoice]); // prints to console if you picked an invalid index before
        Console.ReadLine();

        // integer array with user choice
        int[] integerArray = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };// for math fans
        Console.WriteLine("Choose a number between 0 & 11(0 & 11 are ok)");
        int integerChoice = Convert.ToInt32(Console.ReadLine());

        if (integerChoice > 11) // nothing higher than 5
        {
            Console.WriteLine("Please select a new number and keep it between 0 & 11 this time...");
            integerChoice = Convert.ToInt32(Console.ReadLine()); // saves new input to our variable
        }
        else if (integerChoice < 0) // nothing less than 0
        {
            Console.WriteLine("Please select a new number and keep it between 0 & 11 this time...");
            integerChoice = Convert.ToInt32(Console.ReadLine()); // saves new input to our variable
        }
        else // runs whats after this if you chose a valid index
        {
        }
        Console.WriteLine(integerArray[integerChoice]); // prints to console if you picked an invalid index before
        Console.ReadLine();

        // list of strings with user index choice
        List<string> stringList = new List<string>() { "You", "killed", "my", "father.", "Prepare", "to", "die." }; // more PB refs
        Console.WriteLine("Choose a number between 0 & 6(0 & 6 are ok)");
        int listChoice = Convert.ToInt32(Console.ReadLine());

        if (listChoice > 6)
        {
            Console.WriteLine("Please select a new number and keep it between 0 & 6 this time...");
            listChoice = Convert.ToInt32(Console.ReadLine());
        }
        else // runs whats after this if you chose a valid index
        {
        }
        Console.WriteLine(stringList[listChoice]);
        Console.ReadLine();
    }
}

