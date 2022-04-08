using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.LinkedListTestSources
{
    internal class CopyTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new MyLinkedList(new int[] {1,3,2,4,5}),
                new MyLinkedList(new int[] {1,3,2,4,5}),
            };

            yield return new object[]
            {
                new MyLinkedList(new int[] {1}),
                new MyLinkedList(new int[] {1}),
            };

            yield return new object[]
            {
                new MyLinkedList(new int[] {}),
                new MyLinkedList(new int[] {}),
            };
        }
    }
}

