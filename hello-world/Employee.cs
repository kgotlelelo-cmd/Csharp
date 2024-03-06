using System;
namespace hello_world
{
	public partial class Employee
	{
		public Employee()
		{
		}


		public void DoWork()
		{
			Console.WriteLine("Working...");
		}
	}

	public partial class Employee
	{
		public void GoToLunch()
		{
			Console.WriteLine("Eating...");
		}
	}
}

