using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Theory
{
	class Program
	{
		static void Main(string[] args)
		{
			Animal animal = new Animal(123, "Milou", 1, "ABC");

			// Because "Name" and "Age" are Public
			// So it can be accessed anywhere
			animal.Name = "ABC";
			animal.Age = 123;

			// Because "Species" is Protected
			// So that it can't be accessed from outside the class
			animal.Species = "ZZZ";

			// Because "_id" is Private
			// So that it can't be accessed from outside the class
			animal._id = 123;

		}
	}
}
