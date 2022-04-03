using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.LinkedListTestSources
{
    internal class SortDescendingTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            MyLinkedList list = new MyLinkedList(new int[] { 1, 2, 3, 4 });
            MyLinkedList expectedList = new MyLinkedList(new int[] { 4,3,2,1 });
            yield return new object[] { list, expectedList };

            list = new MyLinkedList(new int[] { 4,3, 2,1});
            expectedList = new MyLinkedList(new int[] { 4,3,2,1});
            yield return new object[] { list, expectedList };

            list = new MyLinkedList(new int[] { });
            expectedList = new MyLinkedList(new int[] { });
            yield return new object[] { list, expectedList };

            list = new MyLinkedList(new int[] { 1 });
            expectedList = new MyLinkedList(new int[] { 1 });
            yield return new object[] { list, expectedList };

            list = new MyLinkedList(new int[] { 0,1});
            expectedList = new MyLinkedList(new int[] { 1,0 });
            yield return new object[] { list, expectedList };


        }
    }
}

