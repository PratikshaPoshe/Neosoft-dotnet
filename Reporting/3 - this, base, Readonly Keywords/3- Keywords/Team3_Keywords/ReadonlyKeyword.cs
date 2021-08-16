using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team3_Keywords
{
    class ReadonlyKeyword
    {
		public readonly string str1;
		public readonly string str2;
		public readonly string str3 = "tokyo";

		public ReadonlyKeyword(string a, string b)
		{

			str1 = a;
			str2 = b;
			Console.WriteLine("Display value of string 1 -- {0}, "
							+ "and string 2 --  {1}", str1, str2);
		}
	}
}
