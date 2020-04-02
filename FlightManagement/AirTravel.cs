using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement
{
	class AirTravel
	{
		public string Name;
		public List<Flight> Flights;
		public List<User> Users;
		public List<Agent> Agents;

		public AirTravel(string name)
		{
			Name = name;
			Flights = new List<Flight>();
			Users = new List<User>();
			Agents = new List<Agent>();
		}

		public void AddFlight(int id, DateTime schedule, decimal ticketPrice)
		{
			Flights.Add(new Flight(id, schedule, ticketPrice));
		}

		public Flight SearchFlightById(int id)
		{
			Flight result = Flights.SingleOrDefault(x => x.Id == id);
			return result;
		}

		public void PrintFlights()
		{
			foreach (var flight in Flights)
			{
				Console.WriteLine("Fight Id: " + flight.Id + ", Schedule: " + flight.Schedule.ToShortDateString());
			}
		}

		public void CreateUser(string email, string password, string address, string fullName)
		{
			Users.Add(new User(email, password, address, fullName));
		}

		public void CreateAgent(string email, string password, string department)
		{
			Agents.Add(new Agent(email, password, department));
		}
	}
}
