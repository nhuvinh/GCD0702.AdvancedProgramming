using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Visitor
{
	class Speak : IAnimalOperation
	{
		public void MonkeyVisitor(Monkey monkey)
		{
			monkey.Shout();
		}

		public void CatVisitor(Cat cat)
		{
			cat.Meow();
			Console.WriteLine("This is a Cat");
		}

		public void DogVisitor(Dog dog)
		{
			dog.Bark();
			Console.WriteLine("This is a VERY BIG DOG...");
		}
	}
}
