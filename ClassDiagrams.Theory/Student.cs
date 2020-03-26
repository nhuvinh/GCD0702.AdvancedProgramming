using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagrams.Theory
{
	class Student
	{
		private string name;
		private int id;
		static private int totalStudents = 0;

		public Student(string n, int i)
		{
			name = n;
			id = i;
			totalStudents += 1;
		}

		public static int getTotalStudent()
		{
			return totalStudents;
		}

		protected int getId()
		{
			// To be implemented
			return 0;
		}

		string getEmail()
		{
			// To be implemented
			return "";
		}
	}
}
