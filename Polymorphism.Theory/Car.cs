using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Theory
{
	public class Car : IVehicle
	{
		public void Run()
		{
			Console.WriteLine("The car is running ...");
		}
	}
}
