using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Lab
{
	class Dog : Animal
	{
		public Dog(string name, string favoriteFood) : base(name, favoriteFood)
		{

		}

		public override string ExplainSelf()
		{
			return base.ExplainSelf() + "\nDJAAF";
		}
	}
}
