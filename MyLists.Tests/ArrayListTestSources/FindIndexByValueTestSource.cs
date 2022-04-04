using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.ArrayListTestSources
{
    internal class FindIndexByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                2,
                new MyArrayList(new int[] {1,2,3,4,5}),
                1,
            };

            yield return new object[]
            {
                0,
                new MyArrayList(new int[] {1,2,3,4,5}),
                -1,
            };

            yield return new object[]
            {
                1,
                new MyArrayList(new int[] {0,1,2,1}),
                1,
            };
        }
    }
}

