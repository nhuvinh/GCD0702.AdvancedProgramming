using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Theory
{
	class Program
	{
		static void Main(string[] args)
		{
			// Can't create an object from an abstract class
			// Animal animal = new Animal("ABC", 1, "abc");

			Dog dog = new Dog("Milou", 1, "Alaska", 4);
			dog.Run();
			Console.WriteLine(dog.Print());
			dog.Eat();

			Console.ReadLine();

			Bird bird = new Bird("Chipmund", 1, "Eagle", 2, 2);
			bird.Fly();
			bird.Eat();
			Console.WriteLine(bird.Print());

			Console.ReadLine();

		}
	}
}
