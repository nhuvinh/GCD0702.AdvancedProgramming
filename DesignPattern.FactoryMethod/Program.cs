using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
	class Program
	{
		static void Main(string[] args)
		{

			IProduct car = Factory.CreateCar();
			car.Run();

			IProduct table = Factory.CreateTable();

			IProduct chair = Factory.CreateChair();

			Console.ReadLine();
		}
	}
}
