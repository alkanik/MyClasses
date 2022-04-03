using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.LinkedListTestSources
{
    internal class FindIndexOfMinTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            MyLinkedList list = new MyLinkedList(new int[] { 1, 2, 3, 4 });
            int expectedIndex = 0;
            yield return new object[] { list, expectedIndex };

            list = new MyLinkedList(new int[] { -1, -10});
            expectedIndex = 1;
            yield return new object[] { list, expectedIndex };

            list = new MyLinkedList(new int[] { 1, 1,1 });
            expectedIndex = 0;
            yield return new object[] { list, expectedIndex };
        }
    }
}

