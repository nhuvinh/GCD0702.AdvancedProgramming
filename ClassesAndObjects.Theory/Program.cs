using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.Theory
{
	class Program
	{
		// Declare a Class
		public class Car
		{
			public string Color; // Property of a Class
			public string BrandName;
			public string Model;
			public int Speed = 0;

			// Constructor without Parameters
			public Car()
			{
				Color = "N/A";
				BrandName = "N/A";
				Model = "N/A";
			}

			// Constructor with Parameters
			public Car(string color, string brandName, string model)
			{
				Color = color;
				BrandName = brandName;
				Model = model;
			}

			// Method
			public void Print()
			{
				Console.WriteLine("Color: " + Color);
				Console.WriteLine("BrandName: " + BrandName);
				Console.WriteLine("Model: " + Model);
				Console.WriteLine("Speed: " + Speed);
			}

			public void IncreaseSpeed(int speed)
			{
				Speed = Speed + speed;
			}

			public void DecreaseSpeed(int speed)
			{
				Speed = Speed - speed;
				if (!IsSpeedGreaterThanZero())
				{
					Speed = 0;
				}
			}

			public bool IsSpeedGreaterThanZero()
			{
				return Speed > 0;
			}
		}
		static void Main(string[] args)
		{
			// Create an Object without Parameter
			Car carFord = new Car();
			//Console.WriteLine("Color of carFord: " + carFord.Color);
			//Console.WriteLine("BrandName of carFord: " + carFord.BrandName);
			//Console.WriteLine("Model of carFord: " + carFord.Model);

			carFord.Print();

			// Access and Set values to Object Properties
			carFord.Color = "Red";
			carFord.BrandName = "Ford";
			carFord.Model = "Mustang";

			Console.WriteLine("=================================\n");
			//Console.WriteLine("Color of carFord: " + carFord.Color);
			//Console.WriteLine("BrandName of carFord: " + carFord.BrandName);
			//Console.WriteLine("Model of carFord: " + carFord.Model);
			carFord.Print();


			// Create an Object with Paramters
			Car carToyota = new Car("Blue", "Toyota", "Prius");
			Console.WriteLine("=================================\n");
			//Console.WriteLine("Color of carToyota: " + carToyota.Color);
			//Console.WriteLine("BrandName of carToyota: " + carToyota.BrandName);
			//Console.WriteLine("Model of carToyota: " + carToyota.Model);
			carToyota.Print();
			Console.ReadLine();

			carToyota.IncreaseSpeed(10);
			carToyota.Print();
			Console.ReadLine();

			carToyota.DecreaseSpeed(20);
			carToyota.Print();

			Console.ReadLine();



		}
	}
}
