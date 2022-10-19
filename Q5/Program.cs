using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入\"Allen\":");
			string input=Console.ReadLine();
			input=input.ToLower();
			if (input == "allen")
			{
				Console.WriteLine("相同");
			}
			else
			{
				Console.WriteLine("不對");
			}

		}
	}
}
