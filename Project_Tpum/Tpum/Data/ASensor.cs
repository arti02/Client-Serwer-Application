using System;
using System.Collections.Generic;
using System.Text;

namespace SerwerData
{
	public abstract class ASensor
	{
		public abstract double getActualTemperature();
		public static ASensor createHeatControl()
		{
			return new Sensor();

		}
	}
}
