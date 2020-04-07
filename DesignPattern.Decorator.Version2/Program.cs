using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator.Version2
{
	class Program
	{
		static void Main(string[] args)
		{
			BlackCoffee blackCoffee = new BlackCoffee();
			Console.WriteLine(blackCoffee.GetDescription());
			Console.WriteLine("Cost: " + blackCoffee.GetCost());
			Console.ReadLine();

			MilkCoffee milkCoffee = new MilkCoffee(blackCoffee);
			Console.WriteLine(milkCoffee.GetDescription());
			Console.WriteLine("Cost: " + milkCoffee.GetCost());
			Console.ReadLine();

		}
	}
}
