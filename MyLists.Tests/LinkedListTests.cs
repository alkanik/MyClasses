using NUnit.Framework;
using System.Collections;
using MyList;
using MyLists.Tests.LinkedListTestSources;
using System;

namespace MyLists.Tests
{
    public class LinkedListTests
    {
        [TestCaseSource(typeof(AddLastTestSource))]
        public void AddLastTest(int value, MyLinkedList list, MyLinkedList expectedList)
        {
            list.AddLast(value);
            MyLinkedList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddFirstTestSource))]
        public void AddFirstTest(int value, MyLinkedList list, MyLinkedList expectedList)
        {
            list.AddFirst(value);
            MyLinkedList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddByIndexTestSource))]
        public void AddByIndexTest(int index, int value, MyLinkedList list, MyLinkedList expectedList)
        {
            list.AddByIndex(index, value);
            MyLinkedList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddByIndexNegativeTestSource))]
        public void AddByIndexTest_WhenIndexIsOutOfRange_ShouldThrowExeption(int index, int value, MyLinkedList list)
        {
            {
                Assert.Throws<IndexOutOfRangeException>(() => list.AddByIndex(index, value));
            }
        }

        [TestCaseSource(typeof(DeleteByIndexTestSource))]
        public void DeleteByIndexTest(int index, MyLinkedList list, MyLinkedList expectedList)
        {
            list.DeleteByIndex(index);
            MyLinkedList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteByIndexNegativeTestSource))]
        public void DeleteByIndexTest_WhenIndexIsOutOfRange_ShouldThrowExeption(int index, MyLinkedList list)
        {
            {
                Assert.Throws<IndexOutOfRangeException>(() => list.DeleteByIndex(index));
            }
        }

        [TestCaseSource(typeof(DeleteLastTestSource))]
        public void DeleteLastTest(MyLinkedList list, MyLinkedList expectedList)
        {
            list.DeleteLast();
            MyLinkedList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteLastNegativeTestSource))]
        public void DeleteLastTest_WhenListIsEmpty_ShouldThrowExeption(MyLinkedList list)
        {
            {
                Assert.Throws<Exception>(() => list.DeleteLast());
            }
        }

        [TestCaseSource(typeof(DeleteFirstTestSource))]
        public void DeleteFirstTest(MyLinkedList list, MyLinkedList expectedList)
        {
            list.DeleteFirst();
            MyLinkedList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteFirstNegativeTestSource))]
        public void DeleteFirstTest_WhenListIsEmpty_ShouldThrowExeption(MyLinkedList list)
        {
            {
                Assert.Throws<Exception>(() => list.DeleteFirst());
            }
        }

        [TestCaseSource(typeof(DeleteNLastTestSource))]
        public void DeleteNLastTest(int n, MyLinkedList list, MyLinkedList expectedList)
        {
            list.DeleteNLast(n);
            MyLinkedList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteNLastNegativeTestSource))]
        public void DeleteNLastTest_WhenNMoreThanLength_ShouldThrowIndexOutOfRangeException(int n, MyLinkedList list)
        {
            {
                Assert.Throws<IndexOutOfRangeException>(() => list.DeleteNLast(n));
            }
        }

        [TestCaseSource(typeof(DeleteNFirstTestSource))]
        public void DeleteNFirstTest(int n, MyLinkedList list, MyLinkedList expectedList)
        {
            list.DeleteNFirst(n);
            MyLinkedList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteNFirstNegativeTestSource))]
        public void DeleteNFirstTest_WhenNMoreThanLength_ShouldThrowIndexOutOfRangeException(int n, MyLinkedList list)
        {
            {
                Assert.Throws<IndexOutOfRangeException>(() => list.DeleteNLast(n));
            }
        }

        [TestCaseSource(typeof(DeleteNByIndexTestSource))]
        public void DeleteNByIndexTest(int index, int n, MyLinkedList list, MyLinkedList expectedList)
        {
            list.DeleteNByIndex(index, n);
            MyLinkedList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteNByIndexNegativeTestSource))]
        public void DeleteNByIndexTest_WhenMoreThanLength_ShouldThrowIndexOutOfRangeException(int index, int n, MyLinkedList list)
        {
            {
                Assert.Throws<IndexOutOfRangeException>(() => list.DeleteNByIndex(index, n));
            }
        }

        [TestCaseSource(typeof(FindIndexByValueTestSource))]
        public void FindIndexByValueTest(int value, MyLinkedList list, int expectedIndex)
        {
            int actualIndex = list.FindIndexByValue(value);
            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestCaseSource(typeof(ChangeValueByIndexTestSource))]
        public void ChangeValueByIndexTest(int index, int value, MyLinkedList list, MyLinkedList expectedList)
        {
            list.ChangeValueByIndex(index, value);
            MyLinkedList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ChangeValueByIndexNegativeTestSource))]
        public void ChangeValueByIndexTest_WhenIndexOutOfRange_ShouldThrowIndexOutOfRangeException(int index, int value, MyLinkedList list)
        {
            {
                Assert.Throws<IndexOutOfRangeException>(() => list.ChangeValueByIndex(index, value));
            }
        }

        [TestCaseSource(typeof(ReverseTestSource))]
        public void ReverseTest(MyLinkedList list, MyLinkedList expectedList)
        {
            list.Reverse();
            MyLinkedList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(FindMaxTestSource))]
        public void FindMaxTest(MyLinkedList list, int expectedValue)
        {
            int actualValue = list.FindMax();
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestCaseSource(typeof(FindMaxNegativeTestSource))]
        public void FindMaxTest_WhenListIsempty_ShouldThrowException(MyLinkedList list)
        {
            {
                Assert.Throws<Exception>(() => list.FindMax());
            }
        }

        [TestCaseSource(typeof(FindMinTestSource))]
        public void FindMinTest(MyLinkedList list, int expectedValue)
        {
            int actualValue = list.FindMin();
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestCaseSource(typeof(FindMinNegativeTestSource))]
        public void FindMinTest_WhenListIsempty_ShouldThrowException(MyLinkedList list)
        {
            {
                Assert.Throws<Exception>(() => list.FindMin());
            }
        }

        [TestCaseSource(typeof(FindIndexOfMaxTestSource))]
        public void FindIndexOfMaxTest(MyLinkedList list, int expectedIndex)
        {
            int actualIndex = list.FindIndexOfMax();
            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestCaseSource(typeof(FindIndexOfMaxNegativeTestSource))]
        public void FindIndexOfMaxTest_WhenListIsempty_ShouldThrowException(MyLinkedList list)
        {
            {
                Assert.Throws<Exception>(() => list.FindIndexOfMax());
            }
        }

        [TestCaseSource(typeof(FindIndexOfMinTestSource))]
        public void FindIndexOfMinTest(MyLinkedList list, int expectedIndex)
        {
            int actualIndex = list.FindIndexOfMin();
            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestCaseSource(typeof(FindIndexOfMinNegativeTestSource))]
        public void FindIndexOfMinTest_WhenListIsempty_ShouldThrowException(MyLinkedList list)
        {
            {
                Assert.Throws<Exception>(() => list.FindIndexOfMin());
            }
        }
    }
}