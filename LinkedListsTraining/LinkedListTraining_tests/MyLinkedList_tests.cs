using LinkedListsTraining;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedListTraining_tests
{
    [TestClass]
    public class MyLinkedList_tests
    {
        [TestMethod]
        public void AddAtHead_OneNumber_CanReturnNumber()
        {
            var input = 2;
            var expected = 2;
            var sut = new MyLinkedList();

            sut.AddAtHead(input);

            var actual = sut.Get(0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddAtTail_OneNumber_CanReturnNumber()
        {
            var input = 2;
            var expected = 2;
            var sut = new MyLinkedList();

            sut.AddAtTail(input);

            var actual = sut.Get(0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteAtIndex_OneNumber_CanReturnNumber()
        {
            var index = 1;

            var expected = -1;
            var sut = new MyLinkedList();

            sut.DeleteAtIndex(index);

            var actual = sut.Get(0);
            Assert.AreEqual(expected, actual);
        }
    }
}