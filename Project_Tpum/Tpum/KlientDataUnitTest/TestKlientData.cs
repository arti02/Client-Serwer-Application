using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Moq;
using KlientData;

namespace DataUnitTests
{
    [TestClass()]
    public class RoomTest
    {
        //private readonly Mock<ARoom> _room_mock = new Mock<ARoom>();
        Client client = Client.Instance;

        [TestMethod()]
        public void Test()
        {
            client.setRoomData("kitchen", 23);
            Assert.AreEqual("kitchen", client.serverRequest.RoomName);
            Assert.AreEqual(23, client.serverRequest.GoalTemp);
        }
        [TestMethod()]
        public void getRoomNameTest()
        {

        }
    }
}
