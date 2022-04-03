using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.LinkedListTestSources
{
    internal class AddListByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 1;
            MyLinkedList list = new MyLinkedList(new int[] { 1, 2, 3, 4 });
            MyLinkedList secondList = new MyLinkedList(new int[] { 5, 6, 7, 8 });
            MyLinkedList expectedList = new MyLinkedList(new int[] { 1, 5, 6, 7, 8, 2, 3, 4, });
            yield return new object[] { index, list, secondList, expectedList };

            index = 1;
            list = new MyLinkedList(new int[] { 1, 2, 3, 4 });
            secondList = new MyLinkedList(new int[] { });
            expectedList = new MyLinkedList(new int[] { 1, 2, 3, 4 });
            yield return new object[] { index, list, secondList, expectedList };

            index = 3;
            list = new MyLinkedList(new int[] { 1, 2, 3, 4 });
            secondList = new MyLinkedList(new int[] { 0 });
            expectedList = new MyLinkedList(new int[] { 1, 2, 3, 0, 4 });
            yield return new object[] { index, list, secondList, expectedList };

            
            

        }
    }
}

