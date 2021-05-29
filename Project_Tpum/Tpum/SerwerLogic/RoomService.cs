using SerwerData;
using SerwerData.Model;
using SerwerLogic.modelDTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SerwerLogic
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _repoReference;

        public RoomService()
        {
            if (_repoReference == null)
            {
                _repoReference = new RoomRepository();
                _repoReference.Add(new Room(1, "kitchen"));
                _repoReference.Add(new Room(2, "bedroom"));
                _repoReference.Add(new Room(3, "bathroom"));
                _repoReference.Add(new Room(4, "livingroom"));
            }
        }
        /*public RoomService(IRoomRepository repository)
        {
            _repoReference = repository;
        }*/

        public async Task<RoomDTO> GetRoom(int id)
        {
            return await Task.FromResult(mapToRoomDTO(_repoReference.Get(id)));
        }

        public async Task<double> GetRoomTemperature(string name)
        {
            return await Task.FromResult(_repoReference.GetTempByName(name));
        }

        public async Task<RoomDTO> GetRoomByName(string name)
        {
            return await Task.FromResult(mapToRoomDTO(_repoReference.GetByName(name)));
        }

        public async Task<IEnumerable<RoomDTO>> GetRooms()
        {
            List<RoomDTO> rooms = new List<RoomDTO>();
            var ro = _repoReference.GetRooms();
            foreach (var r in ro)
            {
                rooms.Add(mapToRoomDTO(r));
            }
            return await Task.FromResult(rooms);
        }

        /*public async Task<bool> UpdateRoom(string name, double goal)
        {
            return await Task.FromResult(_repoReference.Update(name, goal));
        }*/
        public bool UpdateRoom(string name, double goal)
        {
            return _repoReference.Update(name, goal).Result;
        }

        private RoomDTO mapToRoomDTO(Room room)
        {
            return new RoomDTO(room.Id, room.Name, room.Actual, room.Goal);
        }

    }
}
