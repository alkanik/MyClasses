using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.LinkedListTestSources
{
    internal class FindMaxNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            MyLinkedList list = new MyLinkedList(new int[] { });
            yield return new object[] {list };
        }
    }
}

