using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.LinkedListTestSources
{
    internal class FindMinTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            MyLinkedList list = new MyLinkedList(new int[] { 1, 2, 3, 4 });
            int expectedValue = 1;
            yield return new object[] { list, expectedValue };

            list = new MyLinkedList(new int[] { -1, 0});
            expectedValue = -1;
            yield return new object[] { list, expectedValue };

            list = new MyLinkedList(new int[] { 1, 1,1 });
            expectedValue = 1;
            yield return new object[] { list, expectedValue };
        }
    }
}

