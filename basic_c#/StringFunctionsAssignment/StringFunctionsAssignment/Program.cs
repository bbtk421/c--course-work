using System;
using System.Text;

namespace StringFunctionsAssignment
{
    class Program
    {
        static void Main()
        {
            string sentence1 = "String sentence number one. ";
            string sentence2 = "String sentence number two. ";
            string sentence3 = "String sentence number three. ";

            sentence2 = sentence2.ToUpper(); // changing to all uppercase

            Console.WriteLine(sentence1 + sentence2 + sentence3); // concats
            Console.ReadLine();

            StringBuilder sb = new StringBuilder(sentence1 + sentence3); // StringBuilder named sb and (args)

            sb.Append("String sentence number 4."); // add to the end

            sb.Insert(28, sentence2); // insert at given char number


            Console.WriteLine(sb);
            Console.ReadLine();


        }
    }
}
