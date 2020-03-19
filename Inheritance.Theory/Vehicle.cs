using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Theory
{
	public class Vehicle
	{
		public string BrandName;
		public string Model;
		public decimal Price;
		public int Fuel;
		public int Capacity;

		public Vehicle(string brandName, string model,
			decimal price, int fuel, int capacity)
		{
			BrandName = brandName;
			Model = model;
			Price = price;
			Fuel = fuel;
			Capacity = capacity;
		}

		public Vehicle()
		{
			BrandName = "N/A";
			Model = "N/A";
			Price = 0;
			Fuel = 0;
			Capacity = 0;
		}

		public virtual void Run()
		{
			Console.WriteLine("The vehicle is running ...");
		}

		public virtual void ApplyBrakes()
		{
			Console.WriteLine("The vehicle is applying brakes");
		}

		public void IncreaseFuel(int amount)
		{
			Fuel += amount;
		}

		public void DecreaseFuel(int amount)
		{
			Fuel -= amount;
		}

		public virtual void Print()
		{
			Console.WriteLine("BrandName: " + BrandName);
			Console.WriteLine("Model: " + Model);
			Console.WriteLine("Price: " + Price);
			Console.WriteLine("Fuel: " + Fuel);
			Console.WriteLine("Capacity: " + Capacity);
		}
	}
}
