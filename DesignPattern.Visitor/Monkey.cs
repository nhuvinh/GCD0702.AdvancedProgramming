using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Visitor
{
	class Monkey : IAnimal
	{
		public void Shout()
		{
			Console.WriteLine("Azzzzzz...");
		}
		public void Accept(IAnimalOperation operation)
		{
			operation.MonkeyVisitor(this);
		}
	}
}
