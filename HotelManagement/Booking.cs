using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
	class Booking
	{
		public DateTime StartDate;
		public DateTime EndDate;

		public Booking(DateTime startDate, DateTime endDate)
		{
			StartDate = startDate;
			EndDate = endDate;
		}

		public void Print()
		{
			Console.WriteLine("Booking Status | StartDate: " + StartDate.ToShortDateString() + ", EndDate: " + EndDate.ToShortDateString());
		}
	}
}
