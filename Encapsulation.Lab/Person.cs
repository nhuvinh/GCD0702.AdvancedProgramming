using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Lab
{
	class Person
	{
		private string _firstName;
		private string _lastName;
		private int _age;
		private decimal _salary;

		public string FirstName { get; private set; }
		public string LastName { get; private set; }
		public int Age { get; private set; }

		public Person(string firstName, string lastName, int age, decimal salary)
		{
			if (firstName.Length < 3)
			{
				throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
			}

			if (lastName.Length < 3)
			{
				throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
			}

			if (age <= 0)
			{
				throw new ArgumentException("Age cannot be zero or a negative integer!");
			}

			if (salary < 460)
			{
				throw new ArgumentException("Salary cannot be less than 460 leva!");
			}

			_firstName = firstName;
			_lastName = lastName;
			_age = age;
			_salary = salary;

			FirstName = firstName;
			LastName = lastName;
			Age = age;
		}

		public override string ToString()
		{
			return _firstName + " " + _lastName + " is " + _age + " years old, receies " + _salary;
		}

		public void IncreaseSalary(decimal percentage)
		{
			if (_age < 30)
			{
				_salary += _salary * percentage / 2 / 100;
			}
			else
			{
				_salary += _salary * percentage / 100;
			}
		}
	}
}
