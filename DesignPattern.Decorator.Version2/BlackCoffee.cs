using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator.Version2
{
	class BlackCoffee : BaseCoffee
	{
		public BlackCoffee()
		{

		}

		public override double GetCost()
		{
			return 8.0;
		}

		public override string GetDescription()
		{
			return "Black Coffee";
		}
	}
}
