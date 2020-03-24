using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Theory
{
	public class Person : ILivingEntity
	{
		public string FirstName;
		public string LastName;
		public string Address;
		public int Age;

		public void Die()
		{
			Console.WriteLine("This person is dying ...");
		}

		public void Eat()
		{
			Console.WriteLine("This person is eating ...");
		}

		public void Run()
		{
			Console.WriteLine("This person is running ...");
		}

		public void Sleep()
		{
			Console.WriteLine("This person is sleeping ...");
		}

		//public void Drive(Car car)
		//{
		//	Console.WriteLine("The person is driving something ...");
		//	car.Run();
		//}

		//public void Drive(Bus bus)
		//{
		//	Console.WriteLine("The person is driving something ...");
		//	bus.Run();
		//}

		//public void Drive(Bicycle bibycle)
		//{
		//	Console.WriteLine("The person is driving something ...");
		//	bibycle.Run();
		//}

		public void Drive(IVehicle vehicle)
		{
			Console.WriteLine("The person is driving something ...");
			vehicle.Run();
		}
	}
}
