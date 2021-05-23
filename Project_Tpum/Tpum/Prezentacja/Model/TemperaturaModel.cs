


using Logic;

namespace Prezentacja.Model
{
	class TemperaturaModel
	{
		AProcessTemperature processTemperature;

		public TemperaturaModel()
		{
			processTemperature = AProcessTemperature.createProcessTemperature();
		}

		public void initData()
		{
			processTemperature.addRoom("bedroom");
			processTemperature.addRoom("kitchen");
			processTemperature.addRoom("livingroom");
		}

		public double getRoomTemperature(string roomName)
		{
			double actual = processTemperature.getRoomTemperature(roomName);
			return actual;
		}

		public void setGoalTemperature(string roomName, double goalTemperature)
		{
			processTemperature.setGoalTemp(roomName, goalTemperature);
		}
	}
}
