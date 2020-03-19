using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Theory
{
	public class Truck : Vehicle
	{
		public int Weight;
		public int Height;
		public string Company;

		public Truck() : base()
		{
			Weight = 0;
			Height = 0;
			Company = "N/A";
		}

		public Truck(string brandName, string model,
			decimal price, int fuel, int capacity, int weight, int height, string company)
			: base(brandName, model, price, fuel, capacity)
		{
			Weight = weight;
			Height = height;
			Company = company;
		}

		public override void Print()
		{
			base.Print();
			Console.WriteLine("Weight: " + Weight);
			Console.WriteLine("Height: " + Height);
			Console.WriteLine("Company: " + Company);
		}

		public override void Run()
		{
			Console.WriteLine("The truck is running ...");
		}

		public override void ApplyBrakes()
		{
			Console.WriteLine("The truck is applying brakes ...");
		}
	}
}
