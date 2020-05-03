using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingLab.Tests
{
	[TestClass()]
	public class DEQueueTests
	{
		[TestMethod()]
		public void pushFrontTest_LuffyAndZoro_ReturnedLuffy()
		{
			// arrange
			DEQueue<string> queue = new DEQueue<string>();
			string expected = "Luffy";

			// act
			queue.pushFront("Luffy");
			queue.pushBack("Zoro");

			// assert
			Assert.AreEqual(expected, queue.front);
		}

        [TestMethod()]
        public void pushBackTest_LuffyAndZoro_ReturnedZoro()
        {
            // arrange
            DEQueue<string> queue = new DEQueue<string>();
            string expected = "Zoro";

            // act
            queue.pushFront("Luffy");
            queue.pushBack("Zoro");

            // assert
            Assert.AreEqual(expected, queue.back);
        }

        [TestMethod()]
        public void popFrontTest_LuffyAndZoroAndSanji_ReturnedLuffy()
        {
            // arrange
            DEQueue<string> queue = new DEQueue<string>();
            string expected = "Luffy";

            // act
            queue.pushFront("Luffy");
            queue.pushBack("Zoro");
            queue.pushFront("Sanji");
            queue.popFront();

            // assert
            Assert.AreEqual(expected, queue.front);
        }

        [TestMethod()]
        public void popBackTest_LuffyAndZoroAndSanji_ReturnedLuffy()
        {
            // arrange
            DEQueue<string> queue = new DEQueue<string>();
            string expected = "Luffy";

            // act
            queue.pushFront("Luffy");
            queue.pushBack("Zoro");
            queue.pushFront("Sanji");
            queue.popBack();

            // assert
            Assert.AreEqual(expected, queue.back);
        }

        [TestMethod()]
        public void clearTest_LuffyAndZoroAndSanji_ReturnedNami()
        {
            // arrange
            DEQueue<string> queue = new DEQueue<string>();
            string expected = "Nami";

            // act
            queue.pushFront("Luffy");
            queue.pushBack("Zoro");
            queue.pushFront("Sanji");
            queue.Clear();

            queue.pushBack("Nami");
            queue.pushBack("Usopp");
            queue.pushBack("Chopper");

            // assert
            Assert.AreEqual(expected, queue.front);
        }

        [TestMethod()]
        public void sizeTest_LuffyAndZoroAndSanji_Returned3()
        {
            // arrange
            DEQueue<string> queue = new DEQueue<string>();
            int expected = 3;

            // act
            queue.pushFront("Luffy");
            queue.pushBack("Zoro");
            queue.pushFront("Sanji");

            // assert
            Assert.AreEqual(expected, queue.size);
        }
    }
}