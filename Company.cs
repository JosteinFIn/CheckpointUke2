﻿namespace CheckpointUke2
{
	public class Company
	{
		public string Name { get; private set; }
		public int EmployeeCount { get; set; }

		public Company(string name, int empolyeeCount = 0)
		{
			Name = name;
			EmployeeCount = empolyeeCount;
		}
	}

}
