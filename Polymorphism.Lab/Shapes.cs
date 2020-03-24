using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Lab
{
	public abstract class Shapes
	{
		public virtual string Draw()
		{
			return "This is a shape";
		}

		public abstract double CalculatePerimter();
		public abstract double CalculateArea();
	}
}
