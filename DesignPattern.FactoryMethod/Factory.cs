using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
	class Factory
	{
		public static IProduct CreateCar()
		{
			return new Car();
		}

		public static IProduct CreateTable()
		{
			return new Table();
		}

		public static IProduct CreateChair()
		{
			return new Chair();
		}

		public static IProduct CreateBicycle()
		{
			return new Bicycle();
		}
	}
}
