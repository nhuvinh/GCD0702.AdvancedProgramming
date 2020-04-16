using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
	class Bicycle : IProduct
	{
		public void Run()
		{
			Console.WriteLine("Bicycle is running ...");
		}
	}
}
