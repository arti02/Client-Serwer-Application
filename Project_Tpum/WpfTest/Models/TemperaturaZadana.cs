using System;
using System.Collections.Generic;
using System.Text;

namespace WpfTest.Models
{
	class TemperaturaZadana : Temperatura
	{
		public double temp = 0;
		public override double StworzTemperature()
		{
			throw new NotImplementedException();
		}

	}
}
