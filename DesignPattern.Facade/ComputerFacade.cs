using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade
{
	class ComputerFacade
	{
		private Computer _computer;
		public ComputerFacade(Computer comp)
		{
			_computer = comp;
		}

		public void TurnOn()
		{
			_computer.GetElectric();
			_computer.MakeSound();
			_computer.ShowLoadingScreen();
		}

		public void TurnOff()
		{
			_computer.CloseAllWindows();
			_computer.MakeSound();
			_computer.PullOffTheElectric();
		}


	}
}
