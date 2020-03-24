using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Theory
{
	// Class Dog implements Interface ILivingEntity
	public class Dog : ILivingEntity
	{
		public string Name;
		public int Age;
		public string Species;

		public void Die()
		{
			Console.WriteLine("The dog is dying ...");
		}

		public void Eat()
		{
			Console.WriteLine("The dog is eating well ...");
		}

		public void Run()
		{
			Console.WriteLine("The dog is running fast ...");
		}

		public void Sleep()
		{
			Console.WriteLine("The dog is sleeping 7 hours/day ...");
		}
	}
}
