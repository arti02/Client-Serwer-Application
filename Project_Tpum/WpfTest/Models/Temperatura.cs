using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WpfTest.Models
{
	abstract class  Temperatura 
	{
		
		public abstract double StworzTemperature();
		public abstract void ZmienTemperature(double a, double b);
		public abstract double ZwrocTemp();
	}
}
