using System;
using System.Collections.Generic;
using System.Text;

namespace SerwerData.Model
{
	public class Room
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public double Actual { get; set; }
		public double Goal { get; set; }

		public Room(int id, string name)
		{
			this.Id = id;
			this.Name = name;
			this.Actual = generateActualTemp();
			this.Goal = 0;
		}
		public Room(int id, string name,double actual)
		{
			this.Id = id;
			this.Name = name;
			this.Actual =actual;
			this.Goal = 0;
		}

		private static Random rnd = new Random();
		private static double generateActualTemp()
		{
			return rnd.Next(17, 30);
		}
	}
}
