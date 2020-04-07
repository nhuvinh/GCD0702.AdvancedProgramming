using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
	class BubbleSortStrategy : SortedStrategy
	{
		public override void Sort(List<int> dataset)
		{
			Console.WriteLine("Use Bubble Sort Strategy...");
		}
	}
}
