using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebSocketSharp;
using System.Text.Json;






namespace ClientData
{
	
	public class Client
	{


		private static double tempFromSer;
		public static  double TempFromSer
		{
			get
			{
				return tempFromSer;
			}
			set
			{
				tempFromSer = value;
			}
		}

		private static double goalTemp = 0;
		public static double GoalTemp
		{
			get
			{
				return goalTemp;
			}
			set
			{
				goalTemp = value;
			}
		}

		public static async  Task Main(string[] args)
		{
			await Task.Run(() => ConnectCLient());
		}
		public static void ConnectCLient()
		{
			using (WebSocket ws = new WebSocket("ws://localhost:7890/Echo"))
			{
				ws.OnMessage += Ws_OnMesage;

				Console.WriteLine("on mwssage");
				ws.ConnectAsync();

				while (true)
				{
					Console.WriteLine(tempFromSer);
					Thread.Sleep(5000);
					try
					{

						ws.Send(GoalTemp.ToString());

					}
					catch
					{

					}


				}
				Console.ReadKey();
			}

		}

			
		
		public static async  void Ws_OnMesage(object sender, MessageEventArgs e)
		{

			
		   Console.WriteLine("Recived from the sever:" + e.Data);

			TempFromSer=await Task.Run(() => Double.Parse(e.Data));

			
			Console.WriteLine("PARSE " + tempFromSer);
			
		
		}
		
			public static async Task<double> getActual()
		{
			Console.WriteLine("Get actual " + TempFromSer);
			 return await Task.Run(() =>TempFromSer);
		}

		public static void Save(double temp)
		{
		
				TempFromSer = temp;
				
			
		}
		

		public void setGoal(double goal)
		{
			Console.WriteLine("set goal ");
			GoalTemp = goal;
		}
		/*
		public double getActualTemperature()
		{
			Console.WriteLine("******************get temp in client*******************");
			return TempFromSer;
		}
		public double setGoalTemperature(double goalTemperature)
		{
			Console.WriteLine("******************in client*******************");
			using (WebSocket ws = new WebSocket("ws://127.0.0.1:7890/Echo"))
			{
				ws.OnMessage += Ws_OnMesage;
				ws.Connect();
				while (true)
				{
					ws.Send(goalTemperature.ToString());
				}

			}
		}

		private void Ws_OnMesage(object sender, MessageEventArgs e)
		{
			Console.WriteLine("Recived from the sever:" + e.Data);
			TempFromSer = Double.Parse(e.Data);
		}*/
	}
}
