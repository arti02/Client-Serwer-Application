using SerwerLogic.modelDTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SerwerLogic
{
    public interface IRoomService
    {
        Task<RoomDTO> GetRoom(int id);

        Task<double> GetRoomTemperature(string name);

        Task<RoomDTO> GetRoomByName(string name);

        Task<IEnumerable<RoomDTO>> GetRooms();

        //Task<bool> UpdateRoom(string name, double goal);
        bool UpdateRoom(string name, double goal);

    }
}
