using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement
{
	class Agent : Member
	{
		public string Department;
		public Agent(string email, string password, string department)
			: base(email, password)
		{
			Department = department;
		}
		public override bool Login(AirTravel system)
		{
			var result = system.Agents.SingleOrDefault(x => x.Email == Email && x.Password == Password);
			if (result == null) return false;
			else return true;
		}
	}
}
