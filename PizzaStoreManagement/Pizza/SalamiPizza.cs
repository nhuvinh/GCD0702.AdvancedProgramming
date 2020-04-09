using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreManagement.Pizza
{
	class SalamiPizza : Pizza
	{
		private Pizza _pizza;
		public SalamiPizza(Pizza pizza) : base(5.99, 1160, pizza.GetSize())
		{
			_pizza = pizza;
		}
	}
}
