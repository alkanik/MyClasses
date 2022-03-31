using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.LinkedListTestSources
{
    internal class FindIndexByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 1;
            MyLinkedList list = new MyLinkedList(new int[] { 0, 1, 2, 3, 4});
            int expectedIndex = 1;
            yield return new object[] {value, list, expectedIndex };

            value = 1;
            list = new MyLinkedList(new int[] { 1, 0, 2, 1, 1, 1 });
            expectedIndex = 0;
            yield return new object[] { value, list, expectedIndex };

            value = 1;
            list = new MyLinkedList(new int[] { });
            expectedIndex = -1;
            yield return new object[] { value, list, expectedIndex };

            value = 5;
            list = new MyLinkedList(new int[] { 0, 2, 1, 1, 1 });
            expectedIndex = -1;
            yield return new object[] { value, list, expectedIndex };
        }
    }
}

