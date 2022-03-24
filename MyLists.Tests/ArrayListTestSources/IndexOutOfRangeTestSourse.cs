using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.ArrayListTestSources
{
    internal class IndexOutOfRangeTestSourse : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                -1,
                5,
                new MyArrayList(new int[] { 5 }),
            };

            yield return new object[]
            {
                2,
                2,
                new MyArrayList(new int[] { 1 }),
            };

            yield return new object[]
            {
                0,
                2,
                new MyArrayList(new int[] { }),
            };
        }
    }
}

