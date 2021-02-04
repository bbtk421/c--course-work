using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Struct.Number number = new Struct.Number();
            number.Amount = 10;
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
