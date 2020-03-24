using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Lab
{
	class Circle : Shapes
	{
		public double Radius;

		public Circle(double r)
		{
			Radius = r;
		}

		public override double CalculatePerimter()
		{
			return 2 * Math.PI * Radius;
		}

		public override double CalculateArea()
		{
			return Math.PI * Radius * Radius;
		}

		public override string Draw()
		{
			return base.Draw() + " : Circle";
		}
	}
}
