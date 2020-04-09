using PizzaStoreManagement.Beverage;
using PizzaStoreManagement.FranchiseItem;
using PizzaStoreManagement.Pizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreManagement
{
	class Program
	{
		static void Main(string[] args)
		{
			Order order = new Order();

			order.AddProduct(new Water());
			order.AddProduct(new Shirt());
			order.AddProduct(new Wine());

			MargheritaPizza basePizza = new MargheritaPizza(PizzaSize.NormalSize);
			SalamiPizza salamiPizza = new SalamiPizza(basePizza);

			basePizza.AddTopping(new Cheese());

			basePizza.GetDescription();

			Console.ReadLine();
			order.AddProduct(basePizza);


			salamiPizza.AddTopping(new Onion());
			salamiPizza.AddTopping(new Cheese());

			salamiPizza.GetDescription();

			order.AddProduct(salamiPizza);

			Console.WriteLine("Total Price of Order: " + order.GetTotalPrice());

			Console.ReadLine();

			order.ShowDescription();

			Console.ReadLine();


		}
	}
}
