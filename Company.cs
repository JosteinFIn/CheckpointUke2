namespace CheckpointUke2
{
	public class Company
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
