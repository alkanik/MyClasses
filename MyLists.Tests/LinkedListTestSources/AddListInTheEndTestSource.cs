using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.LinkedListTestSources
{
    internal class AddListInTheEndTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            MyLinkedList list = new MyLinkedList(new int[] { 1, 2, 3, 4});
            MyLinkedList secondList = new MyLinkedList(new int[] { 1, 2, 3, 4 });
            MyLinkedList expectedList = new MyLinkedList(new int[] { 1, 2, 3, 4, 1,2,3,4 });
            yield return new object[] { list, secondList, expectedList };

            list = new MyLinkedList(new int[] { });
            secondList = new MyLinkedList(new int[] { 1, 2, 3, 4 });
            expectedList = new MyLinkedList(new int[] { 1, 2, 3, 4});
            yield return new object[] { list, secondList, expectedList };

            list = new MyLinkedList(new int[] { });
            secondList = new MyLinkedList(new int[] { });
            expectedList = new MyLinkedList(new int[] {  });
            yield return new object[] { list, secondList, expectedList };

            list = new MyLinkedList(new int[] {1,2 });
            secondList = new MyLinkedList(new int[] { });
            expectedList = new MyLinkedList(new int[] { 1, 2 });
            yield return new object[] { list, secondList, expectedList };

        }
    }
}

