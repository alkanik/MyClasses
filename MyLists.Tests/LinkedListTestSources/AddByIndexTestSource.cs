using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.LinkedListTestSources
{
    internal class AddByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 0;
            int value = 5;
            MyLinkedList list = new MyLinkedList(new int[] { 1, 2, 3, 4});
            MyLinkedList expectedList = new MyLinkedList(new int[] { 5, 1, 2, 3, 4 });
            yield return new object[] {index, value, list, expectedList };

            index = 0;
            value = 5;
            list = new MyLinkedList(new int[] { });
            expectedList = new MyLinkedList(new int[] { 5 });
            yield return new object[] { index, value, list, expectedList };

            index = 3;
            value = 5;
            list = new MyLinkedList(new int[] {1,2,3,4,5 });
            expectedList = new MyLinkedList(new int[] { 1,2,3,5,4,5 });
            yield return new object[] { index, value, list, expectedList };

            index = 3;
            value = 5;
            list = new MyLinkedList(new int[] { 1, 2, 3 });
            expectedList = new MyLinkedList(new int[] { 1, 2, 3, 5 });
            yield return new object[] { index, value, list, expectedList };
        }
    }
}

