using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;
using Logic;

namespace LogicUnitTests
{
    [TestClass()]
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
    }
}
