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

		}
	}
}
