using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement
{
	abstract class Member
	{
		public string Email;
		public string Password;

		public Member(string email, string password)
		{
			Email = email;
			Password = password;
		}

		public abstract bool Login(AirTravel system);
	}
}
