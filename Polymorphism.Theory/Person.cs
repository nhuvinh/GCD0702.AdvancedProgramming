using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Theory
{
	public class Person
	{
		public virtual void Run()
		{
			Console.WriteLine("This person is running 100 meters");
		}

		public void Run(int distance)
		{
			Console.WriteLine("This person is running " + distance + " meters");
		}

		public void Run(int distance, IVehicle vehicle)
		{
			Console.WriteLine("This person is running very fast " + distance + " meters");
			vehicle.Run();
		}

		public string Run(IVehicle vehicle)
		{
			return "The vehicle is running ...";
		}
	}
}
