using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_DP
{
	class singleton
	{   //necessary to be private and static sothat no other class can access this. And only one memory allocation for singleton instance
		private static singleton singletonInstance;

		//cannot be accessable from outside this class
		private singleton()
		{

		}

		//this method can only be accessable by outside class and create instance if not created and if already created then reuse it. Note :here we are not creating instance twice
		public static singleton getSingletonInstance()
		{
			if (singletonInstance==null)
			{
				singletonInstance = new singleton();
				Console.WriteLine("Inside null class,Object is checked: " + singletonInstance.ToString());
				Console.WriteLine("-------------------");
			}
			return singletonInstance;
		}

		public void printSingleton()
		{
			Console.WriteLine("Inside print singleton object" + singletonInstance.ToString());
			Console.WriteLine("");
		}
	}
}
