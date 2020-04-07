using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
	abstract class SortedStrategy
	{
		public abstract void Sort(List<int> dataset);
	}
}
