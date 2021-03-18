using Calc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalcTestyJednostkowe
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestSum()
		{
			//arrange
			int a = 10;
			int b = 20;
			int expected = 30;
			String action = "+";
			Actions n = new Actions();
			//act


			int actual = n.Sum(a, b, action);


			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void TestSub()
		{
			//arrange
			int a = 20;
			int b = 9;
			int expected = 11;
			String action = "-";
			Actions n = new Actions();
			//act

			int actual = n.Sum(a, b, action);

			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]

		public void TestDivBy_0()
		{
			//arrange
			int a = 10;
			int b = 0;
			int expected = 0;
			String action = "/";
			Actions n = new Actions();
			//act

			int actual = n.Sum(a, b, action);

			//assert
			Assert.AreEqual(expected, actual);
		}
	}

}


