using System;
using System.Collections.Generic;
using System.Text;

namespace TestClientData
{
    internal class Room : ARoom
    {
        private Client client;
        private double actualTemperature;
        private double goalTemperature;
        private string roomName;

        public Room(string roomName, double goalTemperature)
        {
            client = new Client();
            this.roomName = roomName;
            this.actualTemperature = 6;
            this.goalTemperature = goalTemperature;
            

        }
        public Room(string roomName)
        {
            client = new Client();
            this.roomName = roomName;
            this.actualTemperature = 6;
            this.goalTemperature = 0;

        }
        public override double getActualTemperature()
        {
            Console.WriteLine("ACTUAL TEMPERATURE**********" + actualTemperature);
          
            return actualTemperature;
        }

        public override string getRoomName()
        {
            //simulateUpdateTemp();
            return roomName;
        }

        public override void setGoalTemperature(double temperature)
        {
            goalTemperature = temperature;
            client.setGoal(temperature);
            Console.WriteLine("GOAL TEMPERATURE**********" + goalTemperature);
        }

        public override void setRoomName(string name)
        {
            roomName = name;
        }
    }
}
