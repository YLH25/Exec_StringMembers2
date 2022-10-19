using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			////將字串"aLLeN kUO"轉成"Allen Kuo"
			string string1 = "aLLeN kUO";
			string string2= string1.ToLower();
			string char1= string1.Substring(0,1);
			char1 = char1.ToUpper();
			string char6 = string1.Substring(6, 1);
			char6 = char6.ToUpper();
			Console.WriteLine(char1+string2.Substring(1,5)+char6+ string2.Substring(7,2));




		}
	}
}
