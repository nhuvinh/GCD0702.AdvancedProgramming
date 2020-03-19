using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.Lab
{
	public class BankAccount
	{
		private int id { get; set; }
		private decimal balance { get; set; }

		public int Id { get; set; }
		public decimal Balance { get; set; }

		public void Deposit(decimal amount)
		{
			Balance += amount;
		}

		public void Withdraw(decimal amount)
		{
			Balance -= amount;
		}

		public override string ToString()
		{
			return "Id :" + Id + " , Balance: " + Balance;
		}
	}
}
