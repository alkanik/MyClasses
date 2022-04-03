using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.LinkedListTestSources
{
    internal class DeleteFirstByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 1;
            MyLinkedList list = new MyLinkedList(new int[] { 1, 2, 3, 4 });
            int expectedIndex = 0;
            MyLinkedList expectedList = new MyLinkedList(new int[] { 2,3,4 });
            yield return new object[] { value, list, expectedIndex, expectedList };

            value = 1;
            list = new MyLinkedList(new int[] { 2, 1, 4, 1 });
            expectedIndex = 1;
            expectedList = new MyLinkedList(new int[] { 2,4,1 });
            yield return new object[] { value, list, expectedIndex, expectedList };

            value = 1;
            list = new MyLinkedList(new int[] { 2,2});
            expectedIndex = -1;
            expectedList = new MyLinkedList(new int[] { 2,2 });
            yield return new object[] { value, list, expectedIndex, expectedList };

            value = 1;
            list = new MyLinkedList(new int[] { });
            expectedIndex = -1;
            expectedList = new MyLinkedList(new int[] { });
            yield return new object[] { value, list, expectedIndex, expectedList };
        }
    }
}

