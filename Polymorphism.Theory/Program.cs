using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Theory
{
	class Program
	{
		static void Main(string[] args)
		{
			Person myPerson = new Person();
			Car car = new Car();

			myPerson.Run();
			myPerson.Run(1000);
			myPerson.Run(10000, car);
			Console.ReadLine();

			Console.WriteLine(myPerson.Run(car));
			Console.ReadLine();

			UsainBolt usainBolt = new UsainBolt();

			myPerson.Run();
			Console.ReadLine();

			usainBolt.Run();

			Console.ReadLine();

		}
	}
}
