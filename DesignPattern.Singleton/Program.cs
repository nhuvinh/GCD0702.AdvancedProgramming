using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
	class President
	{
		private static President instance;

		private President()
		{

		}

		public static President GetInstance()
		{
			if (instance != null) return instance;
			else
			{
				instance = new President();
				return instance;
			}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			President president_1 = President.GetInstance();

			President president_2 = President.GetInstance();

			Console.WriteLine(president_1.Equals(president_2));

			Console.ReadLine();
		}
	}
}
