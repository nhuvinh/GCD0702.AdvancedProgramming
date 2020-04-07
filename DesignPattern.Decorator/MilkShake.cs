using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
	class MilkShake : ICoffee
	{
		private ICoffee _baseCoffee;
		public MilkShake(ICoffee coffee)
		{
			_baseCoffee = coffee;
		}

		public double GetCost()
		{
			return _baseCoffee.GetCost() + 2.0;
		}

		public string GetDescription()
		{
			return _baseCoffee.GetDescription() + ", MilkShake";
		}
	}
}
