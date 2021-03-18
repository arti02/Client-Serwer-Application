using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
	public class Actions
	{


		static void Main(string[] args)
		{
			Actions n = new Actions();
			n.Sum(10, 0, "/");
			
		}


		public int Sum(int a, int b, String action)
		{
			switch (action)
			{
				case "+":
					return a + b;

				case "-":
					return a - b;

				case "*":
					return a * b;

				case "/":
					if (b == 0)
					{
						Console.WriteLine("Divide by 0");
						return 0;
					}
					return a / b;
				default:
					Console.WriteLine("Invalid action");
					return 0;

			}
		}

	}
}
