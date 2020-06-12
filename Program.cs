using System;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace CheckpointUke2
{
	class Program
	{
		static void Main(string[] args)
		{
			Person p1 = new Person("Petter", 43);
			Employee e1 = new Employee("Ola", 32, DateTime.Today);
			Company c1 = new Company("Eqiuitox", 2);

			Employee.Describe();
		}
	}

}
