using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Theory
{
	public class Dog : Animal
	{
		public int Legs;

		public Dog(string name, int age, string species, int legs)
			: base(name, age, species)
		{
			Legs = legs;
		}

		// Implement abstract methods defined in abstract class Animal
		public override void Run()
		{
			Console.WriteLine("The dog is running with " + Legs + " legs");
		}

		public override void Eat()
		{
			Console.WriteLine("The dog is eating ...");
		}

		// Override method defined in abstract class Animal
		public override string Print()
		{
			return base.Print() + ", " + Legs;
		}
	}
}
