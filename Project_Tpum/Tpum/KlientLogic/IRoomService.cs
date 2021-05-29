using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlientLogic
{
	public interface IRoomService
	{
		double getActualTemp();

		void setGoalTemp(string selectedRoom, double goalTemp);

		
	}
}
