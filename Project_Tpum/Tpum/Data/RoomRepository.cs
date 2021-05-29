using SerwerData.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SerwerData
{
    public class RoomRepository : IRoomRepository
    {
        private readonly DataContext _dataContext;

        public RoomRepository()
        {
            _dataContext = DataContext.Instance;
        }

        public bool Add(Room item)
        {
            _dataContext.Rooms.Add(item);
            return true;
        }

        public Room Get(string name)
        {
            return _dataContext.Rooms.Find(house => house.Name == name);
        }

        public IEnumerable<Room> GetRooms()
        {
            return _dataContext.Rooms;
        }

        public Room Get(int id)
        {
            return _dataContext.Rooms.Find(house => house.Id == id);
        }

        public Room GetByName(string name)
        {
            return _dataContext.Rooms.Find(house => house.Name == name);
        }

        public double GetTempByName(string name)
        {
            Room room = _dataContext.Rooms.Find(r => r.Name == name);
            if (room != null)
            {
                return room.Actual;
            }
            Console.WriteLine("no room found");
            return 0;
        }

        public int Remove(string name)
        {
            return _dataContext.Rooms.RemoveAll(house => house.Name == name);
        }

        public bool Remove(int id)
        {
            return _dataContext.Rooms.RemoveAll(house => house.Id == id) > 0;
        }

        private Random rnd2 = new Random();
        public async Task<bool> Update(string name, double goal)
        {

            Room found = _dataContext.Rooms.Find(room => room.Name == name);
            bool returnValue = false;
            if (found != null)
            {
                found.Goal = goal;
                if (goal == 0 || found.Actual == goal)
                {
                    Console.WriteLine(found.Name + ": changing random ...");
                    int a = rnd2.Next(0, 100);
                    if (a > 50)
                    {
                        found.Actual += 0.1;
                    }
                    else
                    {
                        found.Actual -= 0.1;
                    }
                }
                else if (found.Actual > goal)
                {
                    Console.WriteLine(found.Name + ": decreasing...");
                    found.Actual -= 0.1;
                }
                else if (found.Actual < goal)
                {
                    Console.WriteLine(found.Name + ": increasing...");
                    found.Actual += 0.1;
                }
                else
                {
                    found.Actual = goal;
                }

                returnValue = true;
            }

            return returnValue;
        }


    }
}
