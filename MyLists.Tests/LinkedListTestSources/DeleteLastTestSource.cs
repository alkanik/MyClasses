using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.LinkedListTestSources
{
    internal class DeleteLastTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            MyLinkedList list = new MyLinkedList(new int[] { 1, 2, 3, 4});
            MyLinkedList expectedList = new MyLinkedList(new int[] { 1, 2, 3 });
            yield return new object[] {list, expectedList };

            list = new MyLinkedList(new int[] {1});
            expectedList = new MyLinkedList(new int[] { });
            yield return new object[] { list, expectedList };
        }
    }
}

