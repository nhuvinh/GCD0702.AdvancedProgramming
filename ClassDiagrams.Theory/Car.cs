using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagrams.Theory
{
	public class Car
	{
		public Engine Engine;
		public string Name { set; get; }
		public decimal Price;

		public void SetPrice(decimal price)
		{
			Price = price;
		}

		public decimal GetPrice()
		{
			return Price;
		}

		public Car(Engine engine)
		{
			Engine = engine;
		}
	}
}
