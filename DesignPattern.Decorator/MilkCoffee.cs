using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
	class MilkCoffee : ICoffee
	{
		private ICoffee _baseCoffee;
		public MilkCoffee(ICoffee coffee)
		{
			_baseCoffee = coffee;
		}


		public double GetCost()
		{
			return _baseCoffee.GetCost() + 1.5;
		}

		public string GetDescription()
		{
			return _baseCoffee.GetDescription() + ", Milk";
		}
	}
}
