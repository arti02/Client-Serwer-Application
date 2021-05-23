using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Moq;

using ClientData;

namespace DataUnitTests
{
    [TestClass()]
    public class RoomTest
    {
        private readonly Mock<ARoom> _room_mock = new Mock<ARoom>();

        [TestMethod()]
        public void getActualTemperatureRangeTest()
        {
            var mock = new Moq.Mock<ARoom>();
            mock.Setup(m => m.getActualTemperature()).Returns(20);
            Assert.AreEqual(20, mock.Object.getActualTemperature());
            mock.Verify(m => m.getActualTemperature());
        }
        [TestMethod()]
        public void getRoomNameTest()
        {
            var mock2 = new Moq.Mock<ARoom>();
            mock2.Setup(m2 => m2.getRoomName()).Returns("Bathroom");
            Assert.IsNotNull(mock2.Object.getRoomName());
            mock2.Verify(m2 => m2.getRoomName());
        }
    }
}
