﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeaturesAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            //const string firstName = "Brian";
            //var lastName = "Brown";


            Person myPerson = new Person("Andy", "Johnson");
            Console.WriteLine(myPerson.FName + " " + myPerson.LName);
            Console.ReadLine();
            Person myPerson2 = new Person("Brian");
            Console.WriteLine(myPerson2.FName + " " + myPerson2.LName);
            Console.ReadLine();

        }
    }
}


