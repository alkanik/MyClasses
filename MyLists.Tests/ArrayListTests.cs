using NUnit.Framework;
using System.Collections;
using MyList;
using MyLists.Tests.ArrayListTestSources;

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

        [TestCaseSource(typeof(DeleteAllByValueTestSource))]
        public void DeleteAllByValueTest(int value, MyArrayList list, MyArrayList expectedList, int expectedNumber)
        {
            int actualNumber = list.DeleteAllByValue(value);

            MyArrayList actualList = list;

            Assert.AreEqual(expectedNumber, actualNumber);
            Assert.AreEqual(expectedList, actualList);
        }
    }
}