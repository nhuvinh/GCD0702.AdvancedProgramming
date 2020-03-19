using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Lab
{
	class Program
	{
		static void Main(string[] args)
		{
			Dog myDog = new Dog();
			myDog.Eat();
			myDog.Bark();

			Console.ReadLine();

			Cat myCat = new Cat();
			myCat.Eat();
			myCat.Meow();

			Console.ReadLine();

			Puppy myPuppy = new Puppy();

			myPuppy.Eat();
			myPuppy.Bark();
			myPuppy.Weep();

			Console.ReadLine();

		}
	}
}
