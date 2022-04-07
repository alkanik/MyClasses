using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.ArrayListTestSources
{
    internal class FindMaxTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new MyArrayList(new int[] {1,2,3,4,5}),
                5,
            };

            yield return new object[]
            {
                new MyArrayList(new int[] {1}),
                1,
            };
        }
    }
}

