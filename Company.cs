namespace CheckpointUke2
{
	class Company
	{
		public string Name { get; private set; }
		public int EmployeeCount { get; private set; }

		public Company(string name, int empolyeeCount)
		{
			Name = name;
			EmployeeCount = empolyeeCount;
		}
	}

}
