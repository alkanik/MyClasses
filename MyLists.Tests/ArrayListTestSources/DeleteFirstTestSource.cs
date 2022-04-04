using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.ArrayListTestSources
{
    internal class DeleteFirstTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            MyArrayList list = new MyArrayList(new int[] { 1, 2, 3, 4, 5 });
            MyArrayList expectedList = new MyArrayList(new int[] { 2, 3, 4,5 });
            yield return new object[] {list, expectedList };

            list = new MyArrayList(new int[] { 1 });
            expectedList = new MyArrayList(new int[] {  });
            yield return new object[] { list, expectedList };

        }
    }
}

