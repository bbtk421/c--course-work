using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOptionalParametersAssignemnt
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths method = new Maths();

            Console.WriteLine("Please provide a whole number.");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please provide another whole number(or don't, it's your life...)");
            string num2 = Console.ReadLine();
            if (num2 == "")
            {
                method.Math(num1);
            }
            else
            {
                int num3 = Convert.ToInt32(num2);
                method.Math(num1, num3);
            }


            Console.ReadLine();
        }
    }
}
