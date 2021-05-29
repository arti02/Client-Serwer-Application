using SerwerData.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SerwerData
{
    public interface IRoomRepository
    {
        bool Add(Room item);

        Room Get(string name);

        IEnumerable<Room> GetRooms();

        Room Get(int id);

        Room GetByName(string name);

        double GetTempByName(string name);

        Task<bool> Update(string name, double goal);

    }
}
