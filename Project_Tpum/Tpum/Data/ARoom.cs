using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public abstract class  ARoom
    {
        public abstract double  getActualTemperature();
        public abstract void setGoalTemperature(double temperature);
        public abstract string getRoomName();
        public abstract void setRoomName(string name);
        public static ARoom createRoom( string roomName, double goalTemperature)
        {
            return new Room(roomName, goalTemperature);
              
        }
        public static ARoom createRoom(string roomName)
        {
            return new Room(roomName);

        }
    }
}
