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
    }
}