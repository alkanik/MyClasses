using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.ArrayListTestSources
{
    internal class SortDescendingTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new MyArrayList(new int[] {1,3,2,4,5}),
                new MyArrayList(new int[] {5,4,3,2,1}),
            };

            yield return new object[]
            {
                new MyArrayList(new int[] {1}),
                new MyArrayList(new int[] {1}),
            };

            yield return new object[]
            {
                new MyArrayList(new int[] {}),
                new MyArrayList(new int[] {}),
            };
        }
    }
}

