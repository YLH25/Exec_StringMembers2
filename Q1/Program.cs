using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//將字串" abc  "左右空白刪掉
			string abc = "  abc   ";
			string fixd1=abc.Trim();
			Console.WriteLine(fixd1);
		}
	}
}
