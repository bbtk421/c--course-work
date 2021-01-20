using System;

namespace StudentDailyReport
{
    class Program
    {
        static void Main()
        {
            // greeting message
            Console.WriteLine("The Tech Academy.\nStudent Daily Report.");
            Console.ReadLine();
            
            // report questions
            Console.WriteLine("What is your name?");
            Console.ReadLine();
            string name = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            Console.ReadLine();
            string course = Console.ReadLine();

            Console.WriteLine("What page number?");
            string pageNum = Console.ReadLine();
            int number = Convert.ToInt32(pageNum);
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.");
            string helpNeed = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(helpNeed);
            Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            Console.ReadLine();
            string positiveExp = Console.ReadLine();
            
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            Console.ReadLine();
            string feedback = Console.ReadLine();
            
            Console.WriteLine("How many hours did you study today?");
            string studyTime = Console.ReadLine();
            int hours = Convert.ToInt32(studyTime);
            Console.ReadLine();

            // bye bye message

            Console.WriteLine("Thank you for your answers! \nAn instructor will respond to this shortly.\nHave a great Day!");
            Console.ReadLine();



        }
    }
}
