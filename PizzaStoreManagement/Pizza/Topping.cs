namespace PizzaStoreManagement.Pizza
{
	abstract class Topping
	{
		protected double Price;
		protected double Calories;
		public Topping(double price, double calories)
		{
			Price = price;
			Calories = calories;
		}

		public double GetPrice()
		{
			return Price;
		}
	}
}