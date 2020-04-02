using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement
{
	class User : Member
	{
		public string Address;
		public string FullName;

		public User(string email, string password, string address, string fullName)
			: base(email, password)
		{
			Address = address;
			FullName = fullName;
		}
		public override bool Login(AirTravel system)
		{
			var result = system.Users.SingleOrDefault(x => x.Email == Email && x.Password == Password);
			if (result == null)
			{
				return false;
			}
			else return true;
		}
	}
}
