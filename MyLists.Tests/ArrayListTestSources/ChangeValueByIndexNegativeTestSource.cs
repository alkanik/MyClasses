using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.ArrayListTestSources
{
    internal class ChangeValueByIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 1;
            int value = 1;
            MyArrayList list = new MyArrayList(new int[] { });
            yield return new object[] {index, value, list };

        }
    }
}

