using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.ArrayListTestSources
{
    internal class DeleteByIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 5;
            MyArrayList list = new MyArrayList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] {index, list };

            index = -1;
            list = new MyArrayList(new int[] { 1 });
            yield return new object[] { index, list };

        }
    }
}

