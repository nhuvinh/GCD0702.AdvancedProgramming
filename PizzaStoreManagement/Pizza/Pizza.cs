using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreManagement.Pizza
{
	public enum PizzaSize
	{
		NormalSize,
		FamilySize
	};
	abstract class Pizza : Product
	{
		protected double Calories;
		protected PizzaSize PizzaSize;
		protected List<Topping> Toppings;

		public Pizza(double price, double calories, PizzaSize pizzaSize) : base(price)
		{
			Calories = calories;
			PizzaSize = pizzaSize;
			Toppings = new List<Topping>();
			if (PizzaSize == PizzaSize.FamilySize)
			{
				Price += 4.15;
				Calories *= 1.95;
			}
		}
		public virtual void AddTopping(Topping topping)
		{
			Toppings.Add(topping);
		}

		public PizzaSize GetSize()
		{
			return PizzaSize;
		}

		public override double GetPrice()
		{
			return Price + Toppings.Sum(t => t.GetPrice());
		}

		public override void GetDescription()
		{
			Console.WriteLine(this.ToString());
			foreach (var topping in Toppings)
			{
				Console.WriteLine("\t" + topping.ToString());
			}
		}

		public List<Topping> GetToppings()
		{
			return Toppings;
		}
	}
}
