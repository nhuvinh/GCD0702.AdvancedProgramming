using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Lab
{
	class Rectangle
	{
		Point topLeft;
		Point bottomRight;

		public Rectangle(int topLeftX, int topLeftY, int bottomRightX,
			int bottomRightY)
		{
			topLeft = new Point(topLeftX, topLeftY);
			bottomRight = new Point(bottomRightX, bottomRightY);
		}

		public bool Contains(Point point)
		{
			return point.X >= topLeft.X && point.X <= bottomRight.X
				&& point.Y <= topLeft.Y && point.Y >= bottomRight.Y;
		}
	}
}
