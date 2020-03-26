using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Theory
{
	public class Bird : Animal
	{
		public int Wings;
		public int Legs;

		public Bird(string name, int age, string species,
			int wings, int legs)
			: base(name, age, species)
		{
			Wings = wings;
			Legs = legs;
		}

		// Implement abstract methods defined in class Animal
		public override void Run()
		{
			Console.WriteLine("The bird is running with " + Legs + " legs");
		}

		public override void Eat()
		{
			Console.WriteLine("The bird is eating ...");
		}

		public void Fly()
		{
			Console.WriteLine("The bird is flying with " + Wings + " wings");
		}
	}
}
