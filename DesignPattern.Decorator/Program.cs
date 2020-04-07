using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
	class Program
	{
		static void Main(string[] args)
		{
			SimpleCoffee simpleCoffee = new SimpleCoffee();
			Console.WriteLine(simpleCoffee.GetDescription());
			Console.WriteLine("Cost: " + simpleCoffee.GetCost());
			Console.ReadKey();

			MilkCoffee milkCoffee = new MilkCoffee(simpleCoffee);
			Console.WriteLine(milkCoffee.GetDescription());
			Console.WriteLine("Cost: " + milkCoffee.GetCost());
			Console.ReadKey();

			MilkShake milkShake = new MilkShake(milkCoffee);
			Console.WriteLine(milkShake.GetDescription());
			Console.WriteLine("Cost: " + milkShake.GetCost());
			Console.ReadKey();

		}
	}
}
