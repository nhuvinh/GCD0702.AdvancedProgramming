using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Lab
{
	public class RandomList : List<string>
	{
		public RandomList()
		{

		}
		public string RandomString()
		{
			if (!this.Any()) return null;
			else
			{
				// Generate a random number
				Random rnd = new Random();
				int random = rnd.Next(0, this.Count - 1);

				// Set value
				string result = this[random];

				// Remove the random number in the list
				this.RemoveAt(random);

				// Return the string
				return result;
			}
		}
	}
}
