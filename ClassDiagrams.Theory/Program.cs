using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagrams.Theory
{
	class Program
	{
		static void Main(string[] args)
		{
			Student std_1 = new Student("Tuan", 1);
			Student std_2 = new Student("Tuan", 1);
			Student std_3 = new Student("Tuan", 1);

			Console.WriteLine("TotalStudents: " + Student.getTotalStudent());

			Console.ReadLine();

			Engine engine_1 = new Engine();
			Engine engine_2 = new Engine();

			Car car_1 = new Car(engine_1);
			car_1.Engine = engine_2;
			Car car_2 = new Car(engine_1);

			Book book = new Book();
		}
	}
}
