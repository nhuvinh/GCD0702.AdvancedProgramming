using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreManagement.Beverage
{
	abstract class Beverage : Product
	{
		protected double Calories;
		public Beverage(double price, double calories) : base(price)
		{
			Calories = calories;
		}
	}
}
