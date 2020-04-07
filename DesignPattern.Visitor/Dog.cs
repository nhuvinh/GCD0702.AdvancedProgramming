using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Visitor
{
	class Dog : IAnimal
	{
		public void Bark()
		{
			Console.WriteLine("Woof...woof...");
		}
		public void Accept(IAnimalOperation operation)
		{
			operation.DogVisitor(this);
		}
	}
}
