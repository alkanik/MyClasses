using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.LinkedListTestSources
{
    internal class DeleteNLastNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int n = 5;
            MyLinkedList list = new MyLinkedList(new int[] { 1, 2, 3, 4 });
            yield return new object[] {n, list };
        }
    }
}

