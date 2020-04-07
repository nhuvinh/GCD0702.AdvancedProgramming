using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter
{
	class WolfAdapter : ILion
	{
		private Wolf _wolf;
		public WolfAdapter(Wolf wolf)
		{
			_wolf = wolf;
		}
	}
}
