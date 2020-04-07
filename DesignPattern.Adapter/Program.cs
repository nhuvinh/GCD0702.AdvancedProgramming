using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter
{
	class Program
	{
		static void Main(string[] args)
		{
			AfricanLion africanLion = new AfricanLion();
			AsianLion asianLion = new AsianLion();

			Hunter hunter = new Hunter();
			hunter.Hunt(africanLion);
			hunter.Hunt(asianLion);

			Wolf wolf = new Wolf();
			WolfAdapter wolfAdapter = new WolfAdapter(wolf);
			hunter.Hunt(wolfAdapter);
		}
	}
}
