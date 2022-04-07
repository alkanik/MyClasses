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

        [TestCaseSource(typeof(DeleteLastTestSource))]
        public void DeleteLastTest(MyArrayList list, MyArrayList expectedList)
        {
            list.DeleteLast();

            MyArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteLastAndFirstNegativeTestSource))]
        public void DeleteLastTest_WhenListIsEmpty_ShouldThrowExeption(MyArrayList list)
        {
            {
                Assert.Throws<Exception>(() => list.DeleteLast());
            }
        }

        [TestCaseSource(typeof(DeleteFirstTestSource))]
        public void DeleteFirstTest(MyArrayList list, MyArrayList expectedList)
        {
            list.DeleteFirst();

            MyArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteLastAndFirstNegativeTestSource))]
        public void DeleteFirstTest_WhenListIsEmpty_ShouldThrowExeption(MyArrayList list)
        {
            {
                Assert.Throws<Exception>(() => list.DeleteFirst());
            }
        }

        [TestCaseSource(typeof(DeleteByIndexTestSource))]
        public void DeleteByIndexTest(int index, MyArrayList list, MyArrayList expectedList)
        {
            list.DeleteByIndex(index);

            MyArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteByIndexNegativeTestSource))]
        public void DeleteByIndexTest_WhenIndexIsOutOfRange_ShouldThrowIndexOutOfRangeException(int index, MyArrayList list)
        {
            {
                Assert.Throws<IndexOutOfRangeException>(() => list.DeleteByIndex(index));
            }
        }

        [TestCaseSource(typeof(DeleteNLastTestSource))]
        public void DeleteNLastTest(int n, MyArrayList list, MyArrayList expectedList)
        {
            list.DeleteNLast(n);

            MyArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteNLastNegativeTestSource))]
        public void DeleteNLastTest_WhenListIsEmpty_ShouldThrowExeption(int n, MyArrayList list)
        {
            {
                Assert.Throws<Exception>(() => list.DeleteNLast(n));
            }
        }

        [TestCaseSource(typeof(DeleteNFirstTestSource))]
        public void DeleteNFirstTest(int n, MyArrayList list, MyArrayList expectedList)
        {
            list.DeleteNFirst(n);

            MyArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteNLastNegativeTestSource))]
        public void DeleteNFirstTest_WhenListIsEmpty_ShouldThrowExeption(int n, MyArrayList list)
        {
            {
                Assert.Throws<Exception>(() => list.DeleteNFirst(n));
            }
        }

        [TestCaseSource(typeof(DeleteNByIndexTestSource))]
        public void DeleteNByIndexTest(int n, int index, MyArrayList list, MyArrayList expectedList)
        {
            list.DeleteNByIndex(n, index);

            MyArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteNByIndexNegativeTestSource))]
        public void DeleteNByIndexTest_WhenIndexIsOutOfRange_ShouldThrowIndexOutOfRangeException(int n, int index, MyArrayList list)
        {
            {
                Assert.Throws<IndexOutOfRangeException>(() => list.DeleteNByIndex(n, index));
            }
        }

        [TestCaseSource(typeof(FindIndexByValueTestSource))]
        public void FindIndexByValueTest(int value, MyArrayList list, int expectedIndex)
        {
            int actualIndex = list.FindIndexByValue(value);
            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestCaseSource(typeof(ChangeValueByIndexTestSource))]
        public void ChangeValueByIndexTest(int index, int value, MyArrayList list, MyArrayList expectedList)
        {
            list.ChangeValueByIndex(index, value);
            MyArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ChangeValueByIndexNegativeTestSource))]
        public void ChangeValueByIndexTest_WhenIndexIsOutOfRange_ShouldThrowIndexOutOfRangeException(int index, int value, MyArrayList list)
        {
            {
                Assert.Throws<IndexOutOfRangeException>(() => list.ChangeValueByIndex(index, value));
            }
        }

        [TestCaseSource(typeof(ReverseTestSource))]
        public void ReverseTest(MyArrayList list, MyArrayList expectedList)
        {
            list.Reverse();
            MyArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(FindMaxTestSource))]
        public void FindMaxTest(MyArrayList list, int expectedMax)
        {
            int actualMax = list.FindMax();
            Assert.AreEqual(expectedMax, actualMax);
        }

        [TestCaseSource(typeof(ListIsEmptyNegativeTestSource))]
        public void FindMaxTest_WhenListIsEmpty_ShouldThrowException(MyArrayList list)
        {
            {
                Assert.Throws<Exception>(() => list.FindMax());
            }
        }

        [TestCaseSource(typeof(FindMinTestSource))]
        public void FindMinTest(MyArrayList list, int expectedMin)
        {
            int actualMin = list.FindMin();
            Assert.AreEqual(expectedMin, actualMin);
        }

        [TestCaseSource(typeof(ListIsEmptyNegativeTestSource))]
        public void FindMinTest_WhenListIsEmpty_ShouldThrowException(MyArrayList list)
        {
            {
                Assert.Throws<Exception>(() => list.FindMin());
            }
        }

        [TestCaseSource(typeof(FindIndexMaxTestSource))]
        public void FindIndexMaxTest(MyArrayList list, int expectedIndexMax)
        {
            int actualIndexMax = list.FindIndexMax();
            Assert.AreEqual(expectedIndexMax, actualIndexMax);
        }

        [TestCaseSource(typeof(ListIsEmptyNegativeTestSource))]
        public void FindIndexMaxTest_WhenListIsEmpty_ShouldThrowException(MyArrayList list)
        {
            {
                Assert.Throws<Exception>(() => list.FindIndexMax());
            }
        }

        [TestCaseSource(typeof(FindIndexMinTestSource))]
        public void FindIndexMinTest(MyArrayList list, int expectedIndexMin)
        {
            int actualIndexMin = list.FindIndexMin();
            Assert.AreEqual(expectedIndexMin, actualIndexMin);
        }

        [TestCaseSource(typeof(ListIsEmptyNegativeTestSource))]
        public void FindIndexMinTest_WhenListIsEmpty_ShouldThrowException(MyArrayList list)
        {
            {
                Assert.Throws<Exception>(() => list.FindIndexMin());
            }
        }

        [TestCaseSource(typeof(SortAscendingTestSource))]
        public void SortAscendingTest(MyArrayList list, MyArrayList expectedList)
        {
            list.SortAscending();
            MyArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(SortDescendingTestSource))]
        public void SortDescendingTest(MyArrayList list, MyArrayList expectedList)
        {
            list.SortDescending();
            MyArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteFirstByValueTestSource))]
        public void DeleteFirstByValueTest(int value, MyArrayList list, MyArrayList expectedList, int expectedIndex)
        {
            int actualIndex = list.DeleteFirstByValue(value);

            MyArrayList actualList = list;

            Assert.AreEqual(expectedIndex, actualIndex);
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

        [TestCaseSource(typeof(AddListInTheEndTestSource))]
        public void AddListInTheEndTest(MyArrayList list, MyArrayList secondList, MyArrayList expectedList)
        {
            list.AddListInTheEnd(secondList);

            MyArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListInTheStartTestSource))]
        public void AddListInTheStartTest(MyArrayList list, MyArrayList secondList, MyArrayList expectedList)
        {
            list.AddListInTheStart(secondList);

            MyArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListByIndexTestSource))]
        public void AddListByIndexTest(int index, MyArrayList list, MyArrayList secondList, MyArrayList expectedList)
        {
            list.AddListByIndex(index, secondList);
            MyArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListByIndexNegativeTestSourse))]
        public void AddListByIndexTest_WhenIndexIsOutOfRange_ShouldThrowIndexOutOfRangeException(int index, MyArrayList list, MyArrayList secondList)
        {
            {
                Assert.Throws<IndexOutOfRangeException>(() => list.AddListByIndex(index, secondList));
            }
        }
    }
}