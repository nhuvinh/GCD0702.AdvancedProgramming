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

			RandomList rndList = new RandomList();
			rndList.Add("1");
			rndList.Add("2");
			rndList.Add("3");
			rndList.Add("4");
			rndList.Add("5");
			rndList.Add("6");

			foreach (var item in rndList)
			{
				Console.WriteLine(item);
			}

			Console.ReadLine();

			Console.WriteLine(rndList.RandomString());

			Console.ReadLine();

			foreach (var item in rndList)
			{
				Console.WriteLine(item);
			}

			Console.ReadLine();

			StackOfStrings stackOfStrings = new StackOfStrings();
			stackOfStrings.Push("1");
			stackOfStrings.Push("2");
			stackOfStrings.Push("3");
			stackOfStrings.Push("4");
			stackOfStrings.Push("5");
			stackOfStrings.Push("6");
			stackOfStrings.Push("7");

			stackOfStrings.Print();

			Console.ReadLine();

			Console.WriteLine("=== Peek ===");
			Console.WriteLine(stackOfStrings.Peek());
			stackOfStrings.Print();

			Console.ReadLine();
			Console.WriteLine("=== Pop ===");
			Console.WriteLine(stackOfStrings.Pop());
			Console.ReadLine();

			stackOfStrings.Print();
			Console.ReadLine();







		}
	}
}
