using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.LinkedListTestSources
{
    internal class DeleteByIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = -1;
            MyLinkedList list = new MyLinkedList(new int[] { 1, 2, 3, 4});
            yield return new object[] {index, list };

            index = 5;
            list = new MyLinkedList(new int[] { 1, 2, 3, 4 });
            yield return new object[] { index, list };

            index = 4;
            list = new MyLinkedList(new int[] { 1, 2, 3, 4 });
            yield return new object[] { index, list };

        }
    }
}

