using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Theory
{
	public class Dog : Animal
	{
		public int Legs;

		public Dog(int id, string name, int age, string species, int legs)
			: base(id, name, age, species)
		{
			Legs = legs;
		}

		// Because "Species" is Protected
		// And class Dog inherits class Animal
		// So that class Dog can access "Species"

		// Because "_id" is Private in class Animal
		// So that it can't be accessed from the Child class
		public override string Print()
		{
			return "Dog Name: " + Name + ", Species: " + Species + ", id: " + _id;
		}
	}
}
