using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
	class Hotel
	{
		public string Name;
		public List<Room> SingleRooms;
		public List<Room> DoubleRooms;

		public Hotel(string name)
		{
			Name = name;
			SingleRooms = new List<Room>();
			DoubleRooms = new List<Room>();
		}

		public Room Search(decimal price, int capacity, DateTime startDate, DateTime endDate)
		{
			Room result = null;
			if (capacity == 1)
			{
				// Search in SingleRooms
				result = SingleRooms.SingleOrDefault(
					x => x.Price == price && !x.IsBooked(startDate, endDate));

				if (result == null)
				{
					result = SingleRooms.FirstOrDefault(x => !x.IsBooked(startDate, endDate));
				}
				else result.AddBooking(startDate, endDate);
			}
			else
			{
				// Search in DoubleRooms
				result = DoubleRooms.SingleOrDefault(
					x => x.Price == price && !x.IsBooked(startDate, endDate));

				if (result == null)
				{
					result = DoubleRooms.FirstOrDefault(x => !x.IsBooked(startDate, endDate));
				}
				else result.AddBooking(startDate, endDate);

			}

			return result;
		}

		public void AddRoom(int id, decimal price, Type type)
		{
			if (type.Equals(Type.Single))
			{
				SingleRooms.Add(new Room(id, price, type));
			}
			else DoubleRooms.Add(new Room(id, price, type));
		}

	}
}
