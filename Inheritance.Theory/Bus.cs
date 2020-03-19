using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Theory
{
	public class Bus : Vehicle
	{
		public string Color = "Yellow";
		public string Company;
		public int Speed;

		public Bus() : base()
		{
			Company = "N/A";
			Speed = 0;
		}

		public Bus(string brandName, string model,
			decimal price, int fuel, int capacity, string company, int speed)
			: base(brandName, model, price, fuel, capacity)
		{
			Company = company;
			Speed = speed;
		}

		public override void Run()
		{
			Console.WriteLine("The bus is running ...");
			SetSpeed(50);
		}

		public override void ApplyBrakes()
		{
			Console.WriteLine("The bus is applying brakes ...");
			SetSpeed(0);
		}

		public override void Print()
		{
			base.Print();
			Console.WriteLine("Color: " + Color);
			Console.WriteLine("Company: " + Company);
			Console.WriteLine("Speed: " + Speed);
		}

		public void SetSpeed(int speed)
		{
			Speed = speed;
		}
	}
}
