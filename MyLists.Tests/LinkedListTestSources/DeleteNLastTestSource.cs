using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.LinkedListTestSources
{
    internal class DeleteNLastTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int n = 1;
            MyLinkedList list = new MyLinkedList(new int[] { 1, 2, 3, 4});
            MyLinkedList expectedList = new MyLinkedList(new int[] { 1, 2, 3 });
            yield return new object[] {n, list, expectedList };

            n = 1;
            list = new MyLinkedList(new int[] {1});
            expectedList = new MyLinkedList(new int[] { });
            yield return new object[] {n, list, expectedList };

            n = 3;
            list = new MyLinkedList(new int[] { 1,2,3,4 });
            expectedList = new MyLinkedList(new int[] {1 });
            yield return new object[] {n, list, expectedList };

            n = 0;
            list = new MyLinkedList(new int[] { 1, 2, 3, 4 });
            expectedList = new MyLinkedList(new int[] { 1, 2, 3, 4 });
            yield return new object[] { n, list, expectedList };
        }
    }
}

