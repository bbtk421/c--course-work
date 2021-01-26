using System;
using System.Collections.Generic;


namespace ConsoleAppSixPartAsssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // string array
            string[] stringArray = { "lil'", "Big", "The Real", "OG", "Olde" };

            Console.WriteLine("Please provide your first name:");
            string name = Console.ReadLine();

            for (int s = 0; s < stringArray.Length; s++) // loops through array
            {
                stringArray[s] = stringArray[s] + " " + name; // adds user input to the end of each index value with a space between
            }
            for (int s = 0; s < stringArray.Length; s++) // loops through updated array
            {
                Console.WriteLine("Your incredibly uncreative rap name is: " + stringArray[s]); // prints each index
            }
            Console.ReadLine();

            for (int i = 0; i < stringArray.Length; i++) // loop with '<' operator
            {
                Console.WriteLine(stringArray[i]);
            }

            Console.ReadLine();

            for (int i = 0; i <= 1; i++) // loop with '<=' operator
            {
                Console.WriteLine(stringArray[i]);
            }

            Console.ReadLine();

            // string List
            List<string> listString = new List<string>() { "you","killed","my","father","prepare","to", "die"};

            Console.WriteLine("Please type any word in the rest of the quote, \"Hello, my name is Inigo Montoya...\"(lowercase please)");
            string input = Console.ReadLine();

                foreach (string word in listString) // iterates through list
                {
                    if (word == input) // checks for the string in the list
                    {
                    Console.WriteLine("Correct, you have seen Princess Bride or just know its most popular quote.");
                    Console.WriteLine("\"You killed my father. Prepare to die.\"");
                    break;
                    }
          
                    else
                    {
                    Console.WriteLine("Sorry, try again.");
                    }

                }
            Console.ReadLine();


            // string List with a dupe
            List<string> listString2 = new List<string>() { "blue", "red", "green", "brown", "yellow", "orange", "brown" ,"purple", "white", "black", "pink"};
            Console.WriteLine("Choose a color:(lowercase please)");
            string input2 = Console.ReadLine();

            for (int c = 0; c < listString2.Count; c++) //iterates through list
            {
                if (listString2[c] == input2) // checks for dupelicate value
                {
                    Console.WriteLine("Match found at index: " + c);
                }
                else
                {
                    Console.WriteLine("No match found at this index.");
                }
            }

            Console.ReadLine();


            // string list with dupe
            List<string> listString3 = new List<string>() { "blue", "green", "blue" };
            List<string> listString4 = new List<string>(); // emply list to hold and compare values

            foreach (string color in listString3) // iterates through list
            {
                foreach (string color2 in listString4)
                {
                    if (color == color2) // checks for dupe
                    {
                        Console.WriteLine(color + " has appeared before.");
                    }
                }
                listString4.Add(color); // adds to holding list
            }
            Console.ReadLine();

        }
    }
}
