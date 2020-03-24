using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Theory
{
	public class UsainBolt : Person
	{
		public override void Run()
		{
			base.Run();
			Console.WriteLine("Usain Bolt runs very fast ... 100 meters in 9 seconds");
		}
	}
}
