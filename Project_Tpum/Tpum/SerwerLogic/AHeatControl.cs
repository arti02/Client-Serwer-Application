using System;
using System.Collections.Generic;
using System.Text;

namespace SerwerLogic
{
	public abstract class AHeatControl
	{
		public abstract double getActualTemperature(double goalTemperature);
		public static AHeatControl createHeatControl()
		{
			return new HeatControl();

		}
	}
}
