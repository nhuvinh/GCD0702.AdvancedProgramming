using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Lab
{
	class StackOfStrings
	{
		private List<string> _data;

		public StackOfStrings()
		{
			_data = new List<string>();
		}

		public void Push(string item)
		{
			_data.Add(item);
		}

		public string Pop()
		{
			if (this.IsEmpty()) return null;
			else
			{
				string result = _data[_data.Count - 1];
				_data.RemoveAt(_data.Count - 1);
				return result;
			}
		}

		public string Peek()
		{
			if (this.IsEmpty()) return null;
			else
			{
				return _data[_data.Count - 1];
			}
		}

		public bool IsEmpty()
		{
			return !_data.Any();
		}

		public void Print()
		{
			foreach (var item in _data)
			{
				Console.WriteLine(item);
			}
		}
	}
}
