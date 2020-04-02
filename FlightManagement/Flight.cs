using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement
{
	class Flight
	{
		public int Id;
		public DateTime Schedule;
		public List<Ticket> Tickets;

		public Flight(int id, DateTime schedule, decimal ticketPrice)
		{
			Id = id;
			Schedule = schedule;
			Tickets = new List<Ticket>();
			for (int i = 0; i < 100; i++)
			{
				Tickets.Add(new Ticket(ticketPrice));
			}
		}

		public void Print()
		{
			Console.WriteLine("Flight Id: " + Id + ", Schedule: " + Schedule.ToShortDateString());
			foreach (var ticket in Tickets)
			{
				ticket.Print();
			}
		}
	}
}
