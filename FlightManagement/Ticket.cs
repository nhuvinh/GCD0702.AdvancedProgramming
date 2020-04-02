using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement
{
	class Ticket
	{
		public decimal Price;
		public bool IsBooked;

		public Ticket(decimal price)
		{
			Price = price;
			IsBooked = false;
		}

		public void Book()
		{
			IsBooked = true;
		}

		public void Cancel()
		{
			IsBooked = false;
		}

		public void Print()
		{
			Console.WriteLine("Price: " + Price + ", Booking Status: " + IsBooked);
		}
	}
}
