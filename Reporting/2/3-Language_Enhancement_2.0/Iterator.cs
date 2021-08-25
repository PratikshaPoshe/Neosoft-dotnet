using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Iterator
    {
		public static IEnumerable<string> GetMyList()
		{
			List<string> my_list = new List<string>() { "Cat", "Goat", "Dog", "Cow" };

			foreach (var items in my_list)
			{
				yield return items;
			}
		}
	}
}
