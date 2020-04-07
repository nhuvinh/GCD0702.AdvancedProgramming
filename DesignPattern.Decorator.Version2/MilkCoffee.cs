using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator.Version2
{
	class MilkCoffee : BaseCoffee
	{
		private BaseCoffee _baseCoffee;
		public MilkCoffee(BaseCoffee baseCoffee)
		{
			_baseCoffee = baseCoffee;
		}

		public override double GetCost()
		{
			return _baseCoffee.GetCost() + 1.5;
		}

		public override string GetDescription()
		{
			return _baseCoffee.GetDescription() + ", Milk";
		}
	}
}
