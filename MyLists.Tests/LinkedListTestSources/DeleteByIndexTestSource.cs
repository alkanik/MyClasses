using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.LinkedListTestSources
{
    internal class DeleteByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 0;
            MyLinkedList list = new MyLinkedList(new int[] { 1, 2, 3, 4});
            MyLinkedList expectedList = new MyLinkedList(new int[] { 2, 3, 4 });
            yield return new object[] {index, list, expectedList };

            index = 2;
            list = new MyLinkedList(new int[] {1,2,3,4 });
            expectedList = new MyLinkedList(new int[] { 1,2,4 });
            yield return new object[] { index, list, expectedList };

            index = 3;
            list = new MyLinkedList(new int[] {1,2,3,4 });
            expectedList = new MyLinkedList(new int[] { 1,2,3 });
            yield return new object[] { index, list, expectedList };

            index = 0;
            list = new MyLinkedList(new int[] { 1});
            expectedList = new MyLinkedList(new int[] { });
            yield return new object[] { index, list, expectedList };
        }
    }
}

