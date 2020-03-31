using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Lab
{
	class Student
	{
		public string studentName { get; private set; }
		int studentAge;
		double studentGrade;

		public Student(string name, int age, double grade)
		{
			studentName = name;
			studentAge = age;
			studentGrade = grade;
		}

		public void Show()
		{
			string gradeStatus = studentGrade > 5.00 ?
				"Execellent student" : "Average student";
			Console.WriteLine(studentName + " is " + studentAge +
				" years old. " + gradeStatus);
		}
	}
}
