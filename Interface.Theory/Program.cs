using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Theory
{
	class Program
	{
		static void Main(string[] args)
		{
			Dog myDog = new Dog();
			Person myPerson = new Person();

			myDog.Sleep();
			myPerson.Sleep();

			Console.ReadLine();

			myDog.Eat();
			myPerson.Eat();

			Console.ReadLine();

			Car car = new Car();
			Bicycle bicycle = new Bicycle();
			Bus bus = new Bus();
			Plane plane = new Plane();

			myPerson.Drive(car);
			myPerson.Drive(bus);
			myPerson.Drive(bicycle);
			myPerson.Drive(plane);

			Console.ReadLine();

			// Can't create an Object from an Interface
			// IVehicle vehicle = new Vehicle();
		}
	}
}
