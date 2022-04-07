using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.ArrayListTestSources
{
    internal class SortAscendingTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new MyArrayList(new int[] {5,3,4,2,1}),
                new MyArrayList(new int[] {1,2,3,4,5}),
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

