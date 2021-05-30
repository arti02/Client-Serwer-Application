using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SerwerData;
using SerwerLogic;
using SerwerLogic.modelDTO;
using System;

namespace SerwerLogicUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private Mock<IRoomRepository> repo = new Mock<IRoomRepository>();
        private IRoomService service;

        [TestInitialize]
        public void Setup()
        {
            service = new RoomService();
        }

        [TestMethod()]
        public void GetRoomByNameTest()
        {
            repo.Setup(x => x.GetByName("kitchen")).Returns(new SerwerData.Model.Room(1, "kitchen", 23));
            RoomDTO roomDto = service.GetRoomByName("kitchen").Result;
            Assert.AreEqual(1, roomDto.Id);
            Assert.AreEqual("kitchen", roomDto.Name);
        }
    }
}
