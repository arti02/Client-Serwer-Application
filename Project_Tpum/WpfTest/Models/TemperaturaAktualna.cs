using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace WpfTest.Models
{
	class Temperatura_aktualna : Temperatura
	{
		public double temp=0;

		public override double StworzTemperature()
		{
			
			Random r = new Random();
			if (temp == 0)
			{
				temp = r.Next(24, 30);
			}

			Double Iter = r.NextDouble();
			if (Iter > 0.5)
			{
				temp += 0.2;
			}
			else
			{
				temp -= 0.2;
			}

			double t = Math.Round(temp, 2);
			return t;

		}
	}
}
