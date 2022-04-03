using NUnit.Framework;
using System.Collections;
using MyList;
using MyLists.Tests.ArrayListTestSources;
using System;

namespace MyLists.Tests
{
    public class ArrayListTests
    {
        [TestCaseSource(typeof(AddLastTestSource))]
        public void AddLastTest(int value, MyArrayList list, MyArrayList expectedList)
        {
            list.AddLast(value);
            MyArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddFirstTestSource))]
        public void AddFirstTest(int value, MyArrayList list, MyArrayList expectedList)
        {
            list.AddFirst(value);
            MyArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddByIndexTestSource))]
        public void AddByIndexTest(int index, int value, MyArrayList list, MyArrayList expectedList)
        {
            list.AddByIndex(index, value);
            MyArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(IndexOutOfRangeTestSourse))]
        public void AddByIndexTest_WhenIndexIsOutOfRange_ShouldThrowExeption(int index, int value, MyArrayList list)
        {
            {
                Assert.Throws<IndexOutOfRangeException>(() => list.AddByIndex(index, value));
            }
        }

        [TestCaseSource(typeof(DeleteAllByValueTestSource))]
        public void DeleteAllByValueTest(int value, MyArrayList list, MyArrayList expectedList, int expectedNumber)
        {
            int actualNumber = list.DeleteAllByValue(value);

            MyArrayList actualList = list;

            Assert.AreEqual(expectedNumber, actualNumber);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListInTheEndTestSource))]
        public void AddListInTheEndTest(MyArrayList list, MyArrayList secondList, MyArrayList expectedList)
        {
            list.AddListInTheEnd(secondList);

            MyArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }
    }
}