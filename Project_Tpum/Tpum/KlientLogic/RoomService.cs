using KlientData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlientLogic
{
	public class RoomService : IRoomService
	{
		Client client;
		public RoomService()
		{
			client = Client.Instance;
		}

		public double getActualTemp()
		{
			return client.TempFromSer;
		}

		

		public void setGoalTemp(string selectedRoom, double goalTemp)
		{
			client.setRoomData(selectedRoom, goalTemp);
		}
	}
}
