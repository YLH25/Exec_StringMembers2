using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//將字串"Allen Kuo"轉成"ALLEN KUO"
			string string1 = "Allen Kuo";
			string1 = string1.ToUpper();
			Console.WriteLine(string1);
		}
	}
}
