using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade
{
	class Computer
	{
		public void GetElectric()
		{
			Console.WriteLine("Electric shock ...");
		}

		public void MakeSound()
		{
			Console.WriteLine("beep...beep...");
		}

		public void ShowLoadingScreen()
		{
			Console.WriteLine("Loading screen...");
		}

		public void CloseAllWindows()
		{
			Console.WriteLine("Windows are closing...");
		}
		public void PullOffTheElectric()
		{
			Console.WriteLine("Pull off ...");
		}
	}
}
