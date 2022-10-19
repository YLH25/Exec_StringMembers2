using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//假設有表示日期的字串"1100225"轉為西元年的日期"20210225"
			Console.Write("請輸入日期字串");
			string input=Console.ReadLine();
			int num = Convert.ToInt32(input);
			Console.WriteLine(num+19110000);
		}
	}
}
