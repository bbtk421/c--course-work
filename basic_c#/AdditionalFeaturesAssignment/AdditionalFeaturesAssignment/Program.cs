using System;
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
            const string firstName = "Brian";
            var lastName = "Brown";
        }
            public class Person
            {
                public Person(string fName) : this(fName,"Brown")
                {
                this.fName = fName;
            }
            public string fName { get; set; }
            public string lName { get; set; }
            }
    }   
}


