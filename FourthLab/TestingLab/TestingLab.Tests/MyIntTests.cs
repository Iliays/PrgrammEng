using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingLab.Tests
{
	[TestClass]
	public class MyIntTests
	{
		[TestMethod]
		public void Add_11and89_100_returned()
		{
			// arrange
			MyInt x = new MyInt("11");
			MyInt y = new MyInt(89);
			int expected = 100;

			// act

			MyInt actual = x.Add(y);

			// assert
			Assert.AreEqual(expected, int.Parse(actual.myNumber.ToString()));
		}

		[TestMethod]
		public void Subtract_20and10_10_returned()
		{
			// arrange
			MyInt x = new MyInt(20);
			MyInt y = new MyInt(10);
			int expected = 10;

			// act

			MyInt actual = x.Subtract(y);

			// assert
			Assert.AreEqual(expected, int.Parse(actual.myNumber.ToString()));
		}

		[TestMethod]
		public void Multiply_12and12_144_returned()
		{
			// arrange
			MyInt x = new MyInt(12);
			MyInt y = new MyInt(12);
			int expected = 144;

			// act

			MyInt actual = x.Multiply(y);

			// assert
			Assert.AreEqual(expected, int.Parse(actual.myNumber.ToString()));
		}

		[TestMethod]
		public void Divide_12and4_3_returned()
		{
			// arrange
			MyInt x = new MyInt(12);
			MyInt y = new MyInt(4);
			int expected = 3;

			// act

			MyInt actual = x.Divide(y);

			// assert
			Assert.AreEqual(expected, int.Parse(actual.myNumber.ToString()));
		}

		[TestMethod]
		public void Max_12and4_12_returned()
		{
			// arrange
			MyInt x = new MyInt(12);
			MyInt y = new MyInt(4);
			int expected = 12;

			// act

			MyInt actual = x.Max(y);

			// assert
			Assert.AreEqual(expected, int.Parse(actual.myNumber.ToString()));
		}

		[TestMethod]
		public void Min_12and4_4_returned()
		{
			// arrange
			MyInt x = new MyInt(12);
			MyInt y = new MyInt(4);
			int expected = 4;

			// act

			MyInt actual = x.Min(y);

			// assert
			Assert.AreEqual(expected, int.Parse(actual.myNumber.ToString()));
		}

		[TestMethod]
		public void CompareTo_12and5_false_returned()
		{
			// arrange
			MyInt x = new MyInt(12);
			MyInt y = new MyInt(0b101);
			Boolean expected = false;

			// act

			MyInt actual = x.CompareTo(y);

			// assert
			Assert.AreEqual(expected, Convert.ToBoolean(actual.myNumber.ToString()));
		}

		[TestMethod]
		public void ABS_12and4_false_returned()
		{
			// arrange
			MyInt x = new MyInt(-12);
			int expected = 12;

			// act

			MyInt actual = x.ABS();

			// assert
			Assert.AreEqual(expected, int.Parse(actual.myNumber.ToString()));
		}

		[TestMethod]
		public void GCD_12and24_12_returned()
		{
			// arrange
			MyInt x = new MyInt(12);
			MyInt y = new MyInt(24);
			int expected = 12;

			// act

			MyInt actual = x.GCD(y);

			// assert
			Assert.AreEqual(expected, int.Parse(actual.myNumber.ToString()));
		}
	}
}
