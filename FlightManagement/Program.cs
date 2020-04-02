using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement
{
	class Program
	{
		static void Main(string[] args)
		{
			Flight flight = new Flight(1, new DateTime(2020, 04, 02), 100);
			flight.Print();

			Console.ReadLine();

			AirTravel system = new AirTravel("GCD0702-Flight Management");
			system.AddFlight(1, new DateTime(2020, 04, 02), 100);
			system.AddFlight(2, new DateTime(2020, 04, 12), 200);
			system.AddFlight(3, new DateTime(2020, 04, 22), 100);
			system.AddFlight(4, new DateTime(2020, 05, 02), 300);
			system.AddFlight(5, new DateTime(2020, 05, 19), 100);

			system.PrintFlights();

			system.CreateUser("vinh.hoang@gmail.com", "123", "01 Le Loi", "Vinh Hoang");

			User user = new User("vinh.hoang@gmail.com", "1235555", "01 Le Loi", "Vinh Hoang");
			Console.WriteLine(user.Login(system));

			Console.ReadLine();

			//system.SearchFlightById(4).Print();


		}
	}
}
