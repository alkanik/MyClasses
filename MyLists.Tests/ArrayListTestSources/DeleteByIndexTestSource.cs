using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.ArrayListTestSources
{
    internal class DeleteByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 1;
            MyArrayList list = new MyArrayList(new int[] { 1, 2, 3, 4, 5 });
            MyArrayList expectedList = new MyArrayList(new int[] { 1, 3, 4,5 });
            yield return new object[] {index, list, expectedList };

            index = 0;
            list = new MyArrayList(new int[] { 1 });
            expectedList = new MyArrayList(new int[] {  });
            yield return new object[] { index, list, expectedList };

        }
    }
}

