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
		}
	}
}
