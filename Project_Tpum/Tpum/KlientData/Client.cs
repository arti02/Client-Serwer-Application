using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebSocketSharp;

namespace KlientData
{
		public class Client

		{
			private static Client _instance;
			public static Client Instance
			{
				get
				{
					if (_instance == null)
					{
						return new Client();
					}
					else return _instance;
				}
				private set => _instance = value;
			}

	

			private double tempFromSer;
			public double TempFromSer
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

			public ServerRequest serverRequest = new ServerRequest("default", 0);

			public double Goal { get; set; } = 0;
			public string Name { get; set; } = "default";
			private Client()
			{

				Console.WriteLine("In Konstruktor");
				Connect();

			}
			public async Task Connect()
			{
				await Task.Run(() =>
				{
					using (WebSocket ws = new WebSocket("ws://localhost:8890/Echo"))
					{
						ws.ConnectAsync();
						ws.OnMessage += (sender, e) => {
							
								TempFromSer = Double.Parse(e.Data);
						

						};

						while (true)
						{
							Thread.Sleep(2000);
							
								ws.Send(JsonConvert.SerializeObject(serverRequest, Formatting.Indented));
							
						}
						Console.ReadKey();

					}
				});
			}

			public void setRoomData(String name, double goal)
			{
				serverRequest.RoomName = name;
				serverRequest.GoalTemp = goal;
			}

			

		}
	
}
