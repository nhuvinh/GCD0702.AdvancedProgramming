using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Lab
{
	class Animal
	{
		public string Name;
		public string FavoriteFood;

		public Animal(string name, string favoriteFood)
		{
			Name = name;
			FavoriteFood = favoriteFood;
		}

		public virtual string ExplainSelf()
		{
			return "I am " + Name + " and my fovourite food is " + FavoriteFood;
		}
	}
}
