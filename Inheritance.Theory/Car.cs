using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Theory
{
	public class Car : Vehicle
	{
		public string EngineModel;
		public string Color;

		public Car() : base()
		{
			EngineModel = "N/A";
			Color = "N/A";
		}

		public Car(string brandName, string model, decimal price,
			int fuel, int capacity, string engineModel, string color)
			: base(brandName, model, price, fuel, capacity)
		{
			EngineModel = engineModel;
			Color = color;
		}

		public override void Print()
		{
			base.Print();
			Console.WriteLine("EngineModel: " + EngineModel);
			Console.WriteLine("Color: " + Color);
		}

		public override void Run()
		{
			Console.WriteLine("The car is running ...");
		}

		public override void ApplyBrakes()
		{
			Console.WriteLine("The car is applying brakes ...");
		}
	}
}
