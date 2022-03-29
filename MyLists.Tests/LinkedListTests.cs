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


    }
}