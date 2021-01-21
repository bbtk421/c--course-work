using System;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main()
        {
            // greeting
            Console.WriteLine("Welcome to Random Insurance Co.\nPlease provide the follwing information:");

            // applicant questions
            Console.WriteLine("\nWhat is your age?");
            int applicantAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nHave you ever had a DUI?(true or false)");
            bool applicantDUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("\nHow many speeding tickets do you have?");
            int applicantTickets = Convert.ToInt32(Console.ReadLine());

            // do you qualify? >=15, false, 3<
      
            bool qualifiedAge = applicantAge >= 15;
            bool qualifiedDUI = applicantDUI == false;
            bool qualifiedTickets = applicantTickets < 3;

            // are you?
            Console.WriteLine("\nQualified?");
            Console.ReadLine();
            Console.WriteLine(qualifiedAge && qualifiedDUI && qualifiedTickets == true);
            Console.ReadLine();

        }
    }
}
