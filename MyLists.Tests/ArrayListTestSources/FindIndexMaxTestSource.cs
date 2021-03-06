using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.ArrayListTestSources
{
    internal class FindIndexMaxTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new MyArrayList(new int[] {1,2,3,4,5}),
                4,
            };

            yield return new object[]
            {
                new MyArrayList(new int[] {1}),
                0,
            };
        }
    }
}

