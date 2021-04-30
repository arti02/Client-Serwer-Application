using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public abstract class  AProcessTemperature
    {
        public abstract void addRoom(string name);
        public abstract double getRoomTemperature(String name);
        public abstract void setGoalTemp(string roomName, double goalTemp);
        public static AProcessTemperature createProcessTemperature()
		{
            return new ProcessTemperature();
		}
        /*double getActualTemperature();
        void setGoalTemperature(double temperature);
        string getRoomName();*/
    }
}
