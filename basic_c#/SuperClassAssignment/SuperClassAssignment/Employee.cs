using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClassAssignment
{
    public class Employee<T> : Person // inherit from Person class
    {
        public int Id { get; set; }

        public List<T> Things { get; set; } // Generic List prop


        //public static bool operator ==(Employee employee, Employee employee1)
        //{
        //    return employee.Id == employee1.Id;
        //}

        //public static bool operator !=(Employee employee, Employee employee1)
        //{
        //    return employee.Id != employee1.Id;
        //}
    }
}
