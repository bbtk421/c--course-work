using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace CodeFirstChallenge
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var db = new StudentContext()) // create and save new student
			{
				Console.WriteLine("Please enter your first name.");
				var firstname = Console.ReadLine();
				Console.WriteLine("Please enter your last name.");
				var lastname = Console.ReadLine();
				Console.WriteLine("Please enter your email adresss.");
				var emailaddress = Console.ReadLine();

				var student = new Student { FirstName = firstname, LastName = lastname, EmailAddress = emailaddress };
				db.Students.Add(student);
				db.SaveChanges();

				var query = from s in db.Students
							orderby s.FirstName
							select s;

				Console.WriteLine("All students in the database;");
				foreach (var person in query)
				{
					Console.WriteLine(person.FirstName + " " + person.LastName + " " + person.EmailAddress);
				}

				Console.WriteLine("Press any key to exit...");
				Console.ReadKey();
			}
		}
	}

	public class Student
	{
		public int StudentId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string EmailAddress { get; set; }

		public virtual List<Student> Students { get; set; }
	}

	public class StudentContext : DbContext
	{
		public DbSet<Student> Students { get; set; }
	}
}
