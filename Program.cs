using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_DP
{
	class Program
	{
		static void Main(string[] args)
		{
			singleton.getSingletonInstance().printSingleton();
			singleton.getSingletonInstance().printSingleton();
			singleton.getSingletonInstance().printSingleton();
			singleton.getSingletonInstance().printSingleton();
			Console.Read();
		}
	}
}
