using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethod
{
	class AndroidBuilder : Builder
	{
		public override void Deploy()
		{
			Console.WriteLine("Deploy to Google Play...");
		}

		public override void Implement()
		{
			Console.WriteLine("Implement with Android Studio...");
		}

		public override void Plan()
		{
			Console.WriteLine("Plan to develop an Adnroid App...");
		}

		public override void Test()
		{
			Console.WriteLine("Test an Android App...");
		}
	}
}
