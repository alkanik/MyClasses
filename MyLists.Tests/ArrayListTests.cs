using NUnit.Framework;
using System.Collections;
using MyLists.Tests.ArrayListTestsSources;

namespace MyLists.Tests
{
    public class ArrayListTests
    {
        [TestCaseSource(typeof(DeleteAllByValueTestSource))]
        public void DeleteAllByValueTest(int value, ArrayList list, ArrayList expectedList, int expectedNumber)
        {
            int actualNumber = list.DeleteAllByValue(value);

            ArrayList actualList = list;

            Assert.AreEqual(expectedNumber, actualNumber);
            Assert.AreEqual(expectedList, actualList);
        }
    }
}