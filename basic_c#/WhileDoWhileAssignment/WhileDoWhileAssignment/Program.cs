using System;

namespace WhileDoWhileAssignment
{
    class Program
    {
        static void Main()
        {
            // while loop
            Console.WriteLine("What is the meaning of life and the answer to everything?\n(HINT: it's a number)");
            int life = Convert.ToInt32(Console.ReadLine());
            bool isLife = life == 42;

            while (!isLife) // don't guess correct the first time!
            {
                switch (life)
                {
                    case 42:
                        Console.WriteLine("You guessed 42! Great job, you win!\nSo long and thanks for all the fish!");
                        isLife = true;
                        break;
                    default:
                        Console.WriteLine("You guessed " + life + ", you lose. Go read a book.");
                        Console.WriteLine("What is the meaning of life and the answer to everything?");
                        life = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            Console.ReadLine();


            // do while loop with multiple "correct" answers
            Console.WriteLine("What is one of the most popular numbers for the end of your Steam/Xbox/PSN name\n(mulitple correct answers)");
            int number = Convert.ToInt32(Console.ReadLine());
            bool rightNum = number == 420 || number == 69 || number == 911 || number == 42069;
            do
            {
                switch (number)
                {
                    case 420:
                        Console.WriteLine("You guessed 420, you are correct...and possibly stoned.");
                        rightNum = true;
                        break;
                    case 69:
                        Console.WriteLine("You guessed 69, you are correct...and never 'done' said action.");
                        rightNum = true;
                        break;
                    case 911:
                        Console.WriteLine("You guessed 911, you are correct...never forget.");
                        rightNum = true;
                        break;
                    case 42069:
                        Console.WriteLine("You guessed 42069, you are correct...really doubling down on those meme numbers.");
                        rightNum = true;
                        break;
                    default:
                        Console.WriteLine("Nope, that ain't one of them, try again, and don't think so hard about it.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!rightNum);

            Console.ReadLine();
        }
    }
}
