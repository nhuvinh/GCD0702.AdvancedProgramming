using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.Lab
{
	public class Person
	{
		private string _name { get; set; }
		private int _age { get; set; }
		private List<BankAccount> _accounts { get; set; }

		public Person(string name, int age)
		{
			_name = name;
			_age = age;
		}

		public Person(string name, int age, List<BankAccount> accounts)
		{
			_name = name;
			_age = age;
			_accounts = accounts;
		}

		public decimal GetBalance()
		{
			decimal sum = 0;
			foreach (var account in _accounts)
			{
				sum = sum + account.Balance;
			}

			return sum;
		}

		public void PrintAllAccounts()
		{
			foreach (var acc in _accounts)
			{
				Console.WriteLine(acc.ToString());
			}
		}
	}
}
