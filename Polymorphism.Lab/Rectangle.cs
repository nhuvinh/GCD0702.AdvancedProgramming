using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Lab
{
	class Rectangle : Shapes
	{
		public double Height;
		public double Weight;

		public Rectangle(double h, double w)
		{
			Height = h;
			Weight = w;
		}

		public override double CalculatePerimter()
		{
			return (Height + Weight) * 2;
		}

		public override double CalculateArea()
		{
			return Height * Weight;
		}

		public override string Draw()
		{
			return base.Draw() + " : Rectangle";
		}
	}
}
