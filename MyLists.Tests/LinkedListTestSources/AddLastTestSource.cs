using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.LinkedListTestSources
{
    internal class AddLastTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 5;
            MyLinkedList list = new MyLinkedList(new int[] { 1, 2, 3, 4});
            MyLinkedList expectedList = new MyLinkedList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { value, list, expectedList };

            value = 5;
            list = new MyLinkedList(new int[] { });
            expectedList = new MyLinkedList(new int[] { 5 });
            yield return new object[] { value, list, expectedList };


        }
    }
}

