using System;

namespace CheckpointUke2
{
	public class Employee : Person
	{
		public DateTime HireDate { get; private set; }

		public Employee(string name, int age, DateTime hireDate) :base(name, age)
		{
			HireDate = hireDate;
		}

		public static void Describe()
		{
			Console.WriteLine(@"Employee()");
			Console.WriteLine("\nThis class contains information about Employee");
			Console.WriteLine("\nProperties: ");
			Console.WriteLine("------------ ");
			Console.WriteLine("Name: Name of employee");
			Console.WriteLine("Age: Age of employee");
			Console.WriteLine("HireDate: Date employee was hired");
		}
	}

}
