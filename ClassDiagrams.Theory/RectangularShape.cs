using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagrams.Theory
{
	public class RectangularShape : IShape
	{
		private int width;
		private int height;
		private double area;

		public double Area()
		{
			area = width * height;
			return area;
		}

		public bool contains(int x, int y)
		{
			// To be implemented
			return false;
		}
	}
}
