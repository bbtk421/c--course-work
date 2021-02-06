using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>()
            {
                new Employee() {fName = "Joe", lName = "Dirt", Id = 1 },
                new Employee() {fName = "Brian", lName = "Brown", Id = 2},
                new Employee() {fName = "Bob", lName = "Dole", Id = 3},
                new Employee() {fName = "Robert", lName = "James", Id = 4},
                new Employee() {fName = "Miranda", lName = "Smith", Id = 5},
                new Employee() {fName = "Cody", lName = "Robbins", Id = 6},
                new Employee() {fName = "Michael", lName = "Canales", Id = 7},
                new Employee() {fName = "Matthew", lName = "Baker", Id = 8},
                new Employee() {fName = "Jenny", lName = "Sanchez", Id = 9},
                new Employee() {fName = "Joe", lName = "Schmoe", Id = 10},
            };

            //List<Employee> joes = new List<Employee>();
            //foreach (Employee i in employee)
            //{
            //    if (i.fName == "Joe")
            //    {
            //        joes.Add(i);
            //        Console.WriteLine(i.fName);
            //        Console.ReadLine();
            //    }
            //}
            //List<Employee> lambdajoes = new List<Employee>();
            List<Employee> lambdajoes = employee.Where(x => x.fName == "Joe").ToList();
            foreach (Employee x in lambdajoes)
            {
                Console.WriteLine(x.fName + " " + x.lName);
                Console.ReadLine();
            }
            List<Employee> idlist = employee.Where(y => y.Id > 5).ToList();
            foreach (Employee y in idlist)
            {
                Console.WriteLine(y.Id + " - " + y.fName + " " + y.lName);
                Console.ReadLine();
            }
        }
    }
}
