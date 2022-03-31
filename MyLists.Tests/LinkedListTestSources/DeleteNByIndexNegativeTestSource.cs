using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.LinkedListTestSources
{
    internal class DeleteNByIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 0;
            int n = 5;
            MyLinkedList list = new MyLinkedList(new int[] { 1, 2, 3, 4 });
            yield return new object[] {index, n, list };

            index = 5;
            n = 5;
            list = new MyLinkedList(new int[] { 1, 2, 3, 4 });
            yield return new object[] { index, n, list };
        }
    }
}

