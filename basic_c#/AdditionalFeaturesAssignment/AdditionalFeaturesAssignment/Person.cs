using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeaturesAssignment
{
    public class Person
    {
        public Person(string fName) : this(fName, "Brown")
        {

        }
        public Person(string fName, string lName)
        {
            FName = fName;
            LName = lName;
        }
        public string FName { get; set; }
        public string LName { get; set; }
    
    }
}

