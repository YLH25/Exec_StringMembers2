using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{//計算兩數之和並算到小數第2位
			Console.Write("請輸入第一個數");
			string input1=Console.ReadLine();
			Console.Write("請輸入第二個數");
			string input2=Console.ReadLine();
			double double1=Convert.ToDouble(input1);
			double double2= Convert.ToDouble(input2);
			double sum=double1+double2;
			string finalnum=sum.ToString("#.##");
			Console.WriteLine(finalnum);
			
			

		}
	}
}
