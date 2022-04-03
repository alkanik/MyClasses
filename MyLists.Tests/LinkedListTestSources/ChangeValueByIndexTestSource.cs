using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.LinkedListTestSources
{
    internal class ChangeValueByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 0;
            int value = 2;
            MyLinkedList list = new MyLinkedList(new int[] { 1, 2, 3, 4});
            MyLinkedList expectedList = new MyLinkedList(new int[] { 2, 2, 3, 4 });
            yield return new object[] {index, value, list, expectedList };

            index = 2;
            value = 1;
            list = new MyLinkedList(new int[] {2,2,2,2});
            expectedList = new MyLinkedList(new int[] { 2, 2, 1, 2 });
            yield return new object[] { index, value, list, expectedList };
        }
    }
}

