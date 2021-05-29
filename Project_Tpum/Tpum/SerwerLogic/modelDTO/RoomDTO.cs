using System;
using System.Collections.Generic;
using System.Text;

namespace SerwerLogic.modelDTO
{
	public class RoomDTO
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public double Actual { get; set; }
		public double Goal { get; set; }

		public RoomDTO(int id, string name, double actual, double goal)
		{
			this.Id = id;
			this.Name = name;
			this.Actual = actual;
			this.Goal = goal;
		}
	}
}
