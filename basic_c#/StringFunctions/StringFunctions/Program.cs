using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Brian";
            //string quote = "The man said, \"Hello\", Brian.\nHello on a new line(cinema).\n \tHello on a new tab.";
            //string filePath = @"C:\Users\bbtk4";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();

            //Console.WriteLine(quote);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Brian");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
