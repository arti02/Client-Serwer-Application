using Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    internal class ProcessTemperature : AProcessTemperature
    {

        List<ARoom> rooms;

        public ProcessTemperature()
        {
            rooms = new List<ARoom>();
        }

        public override void addRoom(string roomName)
        {
            rooms.Add(ARoom.createRoom(roomName));
        }

        public override double getRoomTemperature(string name)
        {
            foreach (ARoom r in rooms)
            {

                if (r.getRoomName().Equals(name))
                {
                    return r.getActualTemperature();
                }

            }
            Console.WriteLine("No room with this name exist");
            return 0;
        }

        public override void setGoalTemp(string roomName, double goalTemp)
        {
            foreach (ARoom r in rooms)
            {

                if (r.getRoomName().Equals(roomName))
                {
                    r.setGoalTemperature(goalTemp);
                }
                else
                {
                    Console.WriteLine("No room with this name exist");
                }

            }

        }

    }
}
