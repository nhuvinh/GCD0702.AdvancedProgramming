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
			Factory factory = new Factory();

			IProduct car = factory.CreateCar();

			IProduct table = factory.CreateTable();

			IProduct chair = factory.CreateChair();
		}
	}
}
