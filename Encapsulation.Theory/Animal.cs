using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Theory
{
	public class Animal
	{
		// Access Modifier: Public
		public string Name;
		public int Age;

		// Access Modifier: Protected
		protected string Species;

		// Access Modifier: Private
		private int _id;
		string _address; // Default = Private

		public Animal(int id, string name, int age, string speicies)
		{
			Name = name;
			Age = age;
			Species = speicies;
			_id = id;
		}
		public virtual string Print()
		{
			return Name + ", " + Age + ", " + _id;
		}

		public void Run()
		{
			Console.WriteLine("The Animal is running");
		}
	}
}
