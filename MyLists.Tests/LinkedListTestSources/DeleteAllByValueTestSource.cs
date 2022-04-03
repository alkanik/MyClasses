using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.LinkedListTestSources
{
    internal class DeleteAllByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 1;
            MyLinkedList list = new MyLinkedList(new int[] { 1, 2, 3, 4 });
            int expectedNumber = 1;
            MyLinkedList expectedList = new MyLinkedList(new int[] { 2,3,4 });
            yield return new object[] { value, list, expectedNumber, expectedList };

            value = 1;
            list = new MyLinkedList(new int[] { 2, 1, 4, 1 });
            expectedNumber = 2;
            expectedList = new MyLinkedList(new int[] { 2,4 });
            yield return new object[] { value, list, expectedNumber, expectedList };

            value = 1;
            list = new MyLinkedList(new int[] { 2, 1, 4, 1,5 });
            expectedNumber = 2;
            expectedList = new MyLinkedList(new int[] { 2, 4,5 });
            yield return new object[] { value, list, expectedNumber, expectedList };

            value = 1;
            list = new MyLinkedList(new int[] { 2,2});
            expectedNumber = 0;
            expectedList = new MyLinkedList(new int[] { 2,2 });
            yield return new object[] { value, list, expectedNumber, expectedList };

            value = 1;
            list = new MyLinkedList(new int[] { });
            expectedNumber = 0;
            expectedList = new MyLinkedList(new int[] { });
            yield return new object[] { value, list, expectedNumber, expectedList };
        }
    }
}

