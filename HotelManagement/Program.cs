using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
	class Program
	{
		static void Main(string[] args)
		{
			Booking booking = new Booking(new DateTime(2020, 04, 02), new DateTime(2020, 04, 05));
			booking.Print();

			Console.ReadLine();

			Room room = new Room(1, 100, Type.Single);

			room.AddBooking(new DateTime(2020, 04, 02), new DateTime(2020, 04, 05));
			room.Print();

			Console.ReadLine();

			Hotel hotel = new Hotel("GCD0702");

			hotel.AddRoom(1, 100, Type.Single);
			hotel.AddRoom(2, 120, Type.Single);
			hotel.AddRoom(3, 150, Type.Single);
			hotel.AddRoom(4, 160, Type.Single);
			hotel.AddRoom(5, 200, Type.Single);

			hotel.AddRoom(1, 200, Type.Double);
			hotel.AddRoom(2, 220, Type.Double);
			hotel.AddRoom(3, 240, Type.Double);
			hotel.AddRoom(4, 300, Type.Double);
			hotel.AddRoom(5, 360, Type.Double);
			hotel.AddRoom(6, 400, Type.Double);

			Room searchRoom = hotel.Search(160, 1, new DateTime(2020, 04, 02), new DateTime(2020, 04, 09));
			searchRoom.Print();

			Console.ReadLine();

			searchRoom = hotel.Search(160, 1, new DateTime(2020, 04, 02), new DateTime(2020, 04, 09));
			searchRoom.Print();

			Console.ReadLine();





		}
	}
}
