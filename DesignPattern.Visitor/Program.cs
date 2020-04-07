using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Visitor
{
	class Program
	{
		static void Main(string[] args)
		{
			Cat cat = new Cat();
			Dog dog = new Dog();
			Monkey monkey = new Monkey();

			Speak speak = new Speak();
			Eat eat = new Eat();
			cat.Accept(speak);
			cat.Accept(eat);

			dog.Accept(speak);
			dog.Accept(eat);

			Console.ReadLine();
		}
	}
}
