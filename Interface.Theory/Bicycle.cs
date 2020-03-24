using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Theory
{
	public class Bicycle : IVehicle
	{
		public void Run()
		{
			Console.WriteLine("The bicycle is running ...");
		}
	}
}
