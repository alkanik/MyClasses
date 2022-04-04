using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.ArrayListTestSources
{
    internal class DeleteLastAndFirstNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            MyArrayList list = new MyArrayList(new int[] { });
            yield return new object[] {list };

        }
    }
}

