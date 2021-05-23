using System;
using System.Collections.Generic;
using System.Text;

namespace SerwerData
{
    internal class Sensor : ASensor
    {
        double actualTemperature = generateActualTemp();


        private Random rnd2 = new Random();
        public override double getActualTemperature()
        {

            if (actualTemperature < 16 || actualTemperature > 30)
            {
                getActualTemperature();
            }
            int a = rnd2.Next(0, 100);
            if (a > 50)
            {
                return actualTemperature += 0.1;
            }
            else
            {
                return actualTemperature -= 0.1;
            }
        }

        private static Random rnd = new Random();
        private static double generateActualTemp()
        {
            return rnd.Next(16, 30);
        }

    }
}
