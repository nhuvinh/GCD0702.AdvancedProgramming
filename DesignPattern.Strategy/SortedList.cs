using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
	class SortedList
	{
		private List<int> dataset = new List<int>();
		public void Sort(SortedStrategy strategy)
		{
			strategy.Sort(dataset);
		}
	}
}
