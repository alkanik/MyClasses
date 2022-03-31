using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.LinkedListTestSources
{
    internal class DeleteNByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 1;
            int n = 2;
            MyLinkedList list = new MyLinkedList(new int[] { 0, 1, 2, 3, 4});
            MyLinkedList expectedList = new MyLinkedList(new int[] { 0, 3, 4 });
            yield return new object[] {index, n, list, expectedList };

            index = 0;
            n = 1;
            list = new MyLinkedList(new int[] {1});
            expectedList = new MyLinkedList(new int[] { });
            yield return new object[] {index, n, list, expectedList };

            
        }
    }
}

