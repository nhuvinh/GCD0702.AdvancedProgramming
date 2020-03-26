using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Theory
{
	// Declare an abstract class with keyword "abstract"
	public abstract class Animal
	{
		// Properties
		public string Name;
		public int Age;
		public string Species;

		// Constructor
		public Animal(string name, int age, string species)
		{
			Name = name;
			Age = age;
			Species = species;
		}

		// Method
		public virtual string Print()
		{
			return Name + ", " + Age + ", " + Species;
		}

		// Abstract
		public abstract void Run();
		public abstract void Eat();


	}
}
