using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string phoneNum = "0987657432";
			if (string.IsNullOrEmpty(phoneNum) || phoneNum.Length != 10)
			{
				Console.WriteLine("錯誤");
			}
			else
			{
				string hiddenPhoneNumm = phoneNum.Substring(0, 4) + new string('*', 4) + phoneNum.Substring(8, 2);
				Console.WriteLine(hiddenPhoneNumm);
			}
		}
	}
}
