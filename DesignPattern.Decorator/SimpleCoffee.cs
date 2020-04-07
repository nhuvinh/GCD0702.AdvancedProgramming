using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
	class SimpleCoffee : ICoffee
	{
		public string GetDescription()
		{
			return "Simple Black Coffee";
		}

		public double GetCost()
		{
			return 8.0;
		}
	}
}
