using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
	class Factory
	{
		public IProduct CreateCar()
		{
			return new Car();
		}

		public IProduct CreateTable()
		{
			return new Table();
		}

		public IProduct CreateChair()
		{
			return new Chair();
		}

		public IProduct CreateBicycle()
		{
			return new Bicycle();
		}
	}
}
