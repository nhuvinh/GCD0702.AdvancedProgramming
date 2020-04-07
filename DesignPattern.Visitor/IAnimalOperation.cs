using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Visitor
{
	interface IAnimalOperation
	{
		void MonkeyVisitor(Monkey monkey);

		void CatVisitor(Cat cat);

		void DogVisitor(Dog dog);
	}
}