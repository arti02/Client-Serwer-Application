using SerwerData;
using System;
using System.Collections.Generic;
using System.Text;

namespace SerwerLogic
{
    internal class HeatControl : AHeatControl
    {
        private ASensor aSensor;

        public HeatControl()
        {
            aSensor = ASensor.createHeatControl();
        }

        public override double getActualTemperature(double goalTemperature)
        {
            double actualTemperature = aSensor.getActualTemperature(); ;
            if (goalTemperature == 0 || Math.Round(goalTemperature, 1) == Math.Round(actualTemperature, 1))
            {
                Console.WriteLine("random " + Math.Round(goalTemperature, 1) + " " + Math.Round(actualTemperature, 1));
                return actualTemperature;
            }
            else
            {
                Console.WriteLine("increase decease " + goalTemperature + " " + actualTemperature);
                if (actualTemperature < goalTemperature)
                {
                    return actualTemperature += 0.1;
                }
                else
                {
                    return actualTemperature -= 0.1;
                }
            }
        }
    }
}
