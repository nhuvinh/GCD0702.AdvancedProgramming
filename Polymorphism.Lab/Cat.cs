using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Lab
{
	class Cat : Animal
	{
		public Cat(string name, string favoriteFood) : base(name, favoriteFood)
		{

		}

		public override string ExplainSelf()
		{
			return base.ExplainSelf() + "\nMEEOW";
		}
	}
}
