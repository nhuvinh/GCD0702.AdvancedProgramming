using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Visitor
{
	class Eat : IAnimalOperation
	{
		public void CatVisitor(Cat cat)
		{
			Console.WriteLine("The cat is Eating...");
		}

		public void DogVisitor(Dog dog)
		{
			Console.WriteLine("The Dog is Eating...");
		}

		public void MonkeyVisitor(Monkey monkey)
		{
			Console.WriteLine("The Monkey is Eating...");
		}
	}
}
