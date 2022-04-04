using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.ArrayListTestSources
{
    internal class DeleteNLastNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int n = 1;
            MyArrayList list = new MyArrayList(new int[] { });
            yield return new object[] {n, list };

        }
    }
}

