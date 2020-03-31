using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Lab
{
	class Program
	{
		static void Main(string[] args)
		{
			Point point_1 = new Point(1, 1);
			Point point_2 = new Point(5, 3);

			Rectangle rectangle = new Rectangle(-2, 3, 3, 1);

			Console.WriteLine(rectangle.Contains(point_1)); // Return true
			Console.WriteLine(rectangle.Contains(point_2)); // Return false

			Console.ReadLine();

			Student student_1 = new Student("Pesho", 20, 5.5);
			Student student_2 = new Student("Mimi", 18, 4.5);

			ClassRoom myClass = new ClassRoom();
			myClass.Create(student_1);
			myClass.Create(student_2);

			myClass.Show("Mimi");
			myClass.Show("Pesho");
			myClass.Show("Peter");

			Console.ReadLine();
		}
	}
}
