using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreManagement.Pizza
{
	class HawaiianPizza : Pizza
	{
		private Pizza _pizza;
		public HawaiianPizza(Pizza pizza) : base(6.99, 1024, pizza.GetSize())
		{
			_pizza = pizza;
		}
	}
}
