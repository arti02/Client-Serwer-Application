using SerwerLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace ServerConnect
{
	class Server
	{
		public class Echo : WebSocketBehavior
		{
			private AHeatControl heatControl;

			public Echo()
			{
				heatControl = AHeatControl.createHeatControl();
			}
			protected override  void OnMessage(MessageEventArgs e)
			{
				double temp = heatControl.getActualTemperature(Double.Parse(e.Data));
				Console.WriteLine("Recived message from client " + e.Data);
				Send(temp.ToString());
			}
		}
		static async Task Main(string[] args)
		{
			await Task.Run(() =>
			{
			WebSocketServer wssv = new WebSocketServer("ws://localhost:7890");
				while (true)
				{
				
					wssv.AddWebSocketService<Echo>("/Echo");
					wssv.Start();
				
				Console.WriteLine("Server started on ws://127.0.0.1:7890");
					Console.ReadKey();
					wssv.Stop();
				}
			});

		}
	}
}
