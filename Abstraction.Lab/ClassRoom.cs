using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Lab
{
	class ClassRoom
	{
		List<Student> Students;

		public ClassRoom()
		{
			Students = new List<Student>();
		}

		public void Create(Student student)
		{
			Students.Add(student);
		}

		public void Show(string name)
		{
			var student = Students.Find(x => x.studentName == name);

			if (student == null)
			{
				Console.WriteLine("No matching student name");
			}
			else student.Show();
		}
	}
}
