using Newtonsoft.Json;
using SerwerLogic;
using SerwerLogic.modelDTO;
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
		static IRoomService roomService = new RoomService();
		public class Echo : WebSocketBehavior
		{
			protected override void OnMessage(MessageEventArgs e)
			{
				Console.WriteLine(e.Data);
				ServerRequest request = JsonConvert.DeserializeObject<ServerRequest>(e.Data);

				roomService.UpdateRoom(request.RoomName, request.GoalTemp);
				double temp = roomService.GetRoomTemperature(request.RoomName).Result;
				Send(temp.ToString());
			

			}
		}



		static void Main(string[] args)
		{
			//await Task.Factory.StartNew(() =>
			//{
			WebSocketServer wssv = new WebSocketServer("ws://localhost:8890");
			while (true)
			{
				wssv.AddWebSocketService<Echo>("/Echo");
				wssv.Start();
				Console.WriteLine("Server started on ws://127.0.0.1:8890");

				Console.ReadKey();
				wssv.Stop();
			}

			//});
		}

	}
}
