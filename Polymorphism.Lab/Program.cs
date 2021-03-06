﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Lab
{
	class Program
	{
		static void Main(string[] args)
		{
			MathOperations mo = new MathOperations();
			Console.WriteLine(mo.Add(2, 3));
			Console.WriteLine(mo.Add(2.2, 3.3, 5.5));
			Console.WriteLine(mo.Add(2.2m, 3.3m, 4.4m));

			Console.ReadLine();

			Animal animal = new Animal("testAnimal", "testFood");
			Console.WriteLine(animal.ExplainSelf());

			Console.ReadLine();

			Animal dog = new Dog("Gosho", "Meat");
			Console.WriteLine(dog.ExplainSelf());

			Console.ReadLine();

			Animal cat = new Cat("Pesho", "Whiskas");
			Console.WriteLine(cat.ExplainSelf());

			Console.ReadLine();

			Rectangle rectangle = new Rectangle(10.9, 20.3);
			Console.WriteLine(rectangle.CalculatePerimter());
			Console.WriteLine(rectangle.CalculateArea());
			Console.WriteLine(rectangle.Draw());

			Console.ReadLine();

			Circle circle = new Circle(3.54);
			Console.WriteLine(circle.CalculatePerimter());
			Console.WriteLine(circle.CalculateArea());
			Console.WriteLine(circle.Draw());

			Console.ReadLine();



		}
	}
}
