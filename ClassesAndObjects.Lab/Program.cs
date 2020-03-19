using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.Lab
{
	class Program
	{
		static void Main(string[] args)
		{
			BankAccount acc = new BankAccount();
			acc.Id = 1;
			acc.Balance = 15;

			Console.WriteLine(acc);

			Console.ReadLine();

			acc.Deposit(20);
			Console.WriteLine(acc);
			Console.ReadLine();

			acc.Withdraw(25);
			Console.WriteLine(acc);
			Console.ReadLine();

			List<BankAccount> accounts = new List<BankAccount>()
			{
				new BankAccount(1, 20),
				new BankAccount(2, 30),
				new BankAccount(3, 1000),
				new BankAccount(4, 2000)
			};

			Person person = new Person("Vinh Hoang", 30, accounts);

			Console.WriteLine("=== Person ===");
			person.PrintAllAccounts();

			Console.ReadLine();

			Console.WriteLine(person.GetBalance());

			Console.ReadLine();


		}
	}
}
