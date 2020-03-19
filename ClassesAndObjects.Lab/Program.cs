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



		}
	}
}
