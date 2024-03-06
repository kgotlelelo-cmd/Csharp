using System;
namespace hello_world
{
	public class Animal
	{
		int age;
		public Animal()
		{
		}

		public Animal(int age)
		{
			this.age = age;
		}

		public string ?Name { get; set; }

		public string Moves()
		{
			return $"${Name} is moving";
		}
	}
}