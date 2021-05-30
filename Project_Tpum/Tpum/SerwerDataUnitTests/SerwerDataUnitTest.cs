using Microsoft.VisualStudio.TestTools.UnitTesting;
using SerwerData;
using SerwerData.Model;
using System;

namespace SerwerDataUnitTests
{
    [TestClass]
    public class SensorTest
    {
        private IRoomRepository repo;

        [TestInitialize]
        public void Setup()
        {

            repo = new RoomRepository();
            repo.Add(new Room(1, "kitchen", 23));
            repo.Add(new Room(2, "bedroom", 26));
            repo.Add(new Room(3, "bathroom", 19));
        }

        [TestMethod()]
        public void GetByNameTest()
        {
            string name = "kitchen";
            Room expected = new Room(1, "kitchen", 23);
            Room actual = repo.GetByName(name);
            Assert.AreEqual(expected.Id, actual.Id);
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Actual, actual.Actual);
        }

        [TestMethod()]
        public void GetTempByNameTest()
        {
            string name = "bedroom";
            double actual = repo.GetTempByName(name);
            Assert.AreEqual(26, actual);
        }
    }
}
