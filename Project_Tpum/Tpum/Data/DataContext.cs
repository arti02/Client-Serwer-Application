using SerwerData.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SerwerData
{
    public class DataContext
    {
        public static DataContext Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataContext();
                }
                return _instance;
            }
        }
        private static DataContext _instance = null;

        public List<Room> Rooms { get; set; } = new List<Room>();
    }
}
