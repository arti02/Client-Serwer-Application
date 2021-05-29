


using KlientLogic;


namespace Prezentacja.Model
{
	public class TemperaturaModel
	{
		IRoomService roomService;

		public TemperaturaModel()
		{
			roomService =new RoomService();
		}

		public double getActualTemp()
		{
			return roomService.getActualTemp();
		}

	
		public void setGoalTemp(string selectedRoom, double goalTemp)
		{
			roomService.setGoalTemp(selectedRoom, goalTemp);
		}
	}
}
