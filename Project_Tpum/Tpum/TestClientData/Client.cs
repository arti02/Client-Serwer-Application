using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebSocketSharp;

namespace TestClientData
{/*
	public class Client
	{
		private static double tempFromSer;
		public static double TempFromSer
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
		public Client()
		{

		}

		public void connect()
		{

			using (WebSocket ws = new WebSocket("ws://localhost/Echo"))
			{

				ws.OnMessage += Ws_OnMesage;
				Console.WriteLine("on mwssage");
				ws.Connect();
				while (true)
				{
					Console.WriteLine("in connect -----------------------");
					Thread.Sleep(2000);
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
		public void Ws_OnMesage(object sender, MessageEventArgs e)
		{
			Console.WriteLine("Recived from the sever:" + e.Data);
			TempFromSer = Double.Parse(e.Data);
			Console.WriteLine("PARSE " + TempFromSer);
			Console.WriteLine("getActual() " + getActual());
		}

		public static double getActual()
		{
			//Console.WriteLine("Get actual " + TempFromSer);
			return TempFromSer;
		}


		public void setGoal(double goal)
		{
			Console.WriteLine("set goal " + GoalTemp);
			GoalTemp = goal;
		}
	}
	*/
}
	