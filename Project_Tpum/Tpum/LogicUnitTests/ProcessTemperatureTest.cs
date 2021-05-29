using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;


namespace LogicUnitTests
{
   /* [TestClass()]
    public class ProcessTemperatureTest
    {
        private readonly Mock<AProcessTemperature> _temp_mock = new Mock<AProcessTemperature>();

        [TestMethod()]
        public void CreateProcessTemperatureTest()
        {
            var mock = new Moq.Mock<AProcessTemperature>();
            mock.Setup(m => m.getRoomTemperature("Bathroom")).Returns(20);
            Assert.IsNotNull(mock.Object.getRoomTemperature("Bathroom"));
            mock.Verify(m => m.getRoomTemperature("Bathroom"));
        }
        [TestMethod]
        public void RoomCreatedTest()
        {
            AProcessTemperature process = AProcessTemperature.createProcessTemperature();
            process.addRoom("Room1");
            double temperature = process.getRoomTemperature("Room1");
            Assert.IsNotNull(temperature);
        }

        [TestMethod]
        public void RoomCreatedTest2()
        {
            AProcessTemperature process = AProcessTemperature.createProcessTemperature();
            process.addRoom("Room1");
            double temperature = process.getRoomTemperature("Room2");
            Assert.AreEqual(0, temperature);
        }


    }*/
}
