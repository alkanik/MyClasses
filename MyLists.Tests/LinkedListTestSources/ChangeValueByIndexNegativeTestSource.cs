using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.LinkedListTestSources
{
    internal class ChangeValueByIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 5;
            int value = 1;
            MyLinkedList list = new MyLinkedList(new int[] { 1, 2, 3, 4 });
            yield return new object[] {index, value, list };

            index = -1;
            value = 1;
            list = new MyLinkedList(new int[] { 1, 2, 3, 4 });
            yield return new object[] { index, value, list };
        }
    }
}

