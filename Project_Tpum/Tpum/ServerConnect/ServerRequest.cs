using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerConnect
{
	class ServerRequest
	{
		
		public string RoomName { get; set; }
		public double GoalTemp { get; set; }

		public ServerRequest( string roomName, double goalTemp)
		{
			
			this.RoomName = roomName;
			this.GoalTemp = goalTemp;
		}
	}
}
