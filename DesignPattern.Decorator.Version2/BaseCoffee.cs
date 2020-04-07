using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator.Version2
{
	abstract class BaseCoffee
	{
		public abstract double GetCost();
		public abstract string GetDescription();
	}
}
