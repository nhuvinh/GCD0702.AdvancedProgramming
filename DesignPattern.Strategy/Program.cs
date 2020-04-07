using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
	class Program
	{
		static void Main(string[] args)
		{
			SortedList sortedList = new SortedList();

			sortedList.Sort(new BubbleSortStrategy());
			Console.ReadLine();

			sortedList.Sort(new QuickSortStrategy());
			Console.ReadLine();

		}
	}
}
