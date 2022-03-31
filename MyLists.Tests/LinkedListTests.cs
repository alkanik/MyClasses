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
    }
}