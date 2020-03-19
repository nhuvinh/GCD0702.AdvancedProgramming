using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Theory
{
	class Program
	{
		static void Main(string[] args)
		{
			Vehicle myVehicle = new Vehicle("ABC", "xyz", 1000, 100, 2);
			myVehicle.Print();

			Console.ReadLine();

			Car myCar = new Car("Tesla", "T-Model", 1000000
				, 100, 4, "SuperEngine", "White");
			myCar.Print();

			Console.ReadLine();
		}
	}
}
