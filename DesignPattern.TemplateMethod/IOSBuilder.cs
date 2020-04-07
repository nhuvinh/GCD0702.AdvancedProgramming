using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethod
{
	class IOSBuilder : Builder
	{
		public override void Deploy()
		{
			Console.WriteLine("Deploy to App Store...");
		}

		public override void Implement()
		{
			Console.WriteLine("Implement with XCode...");
		}

		public override void Plan()
		{
			Console.WriteLine("Plan to develop an iOS App...");
		}

		public override void Test()
		{
			Console.WriteLine("Test an iOS app...");
		}
	}
}
