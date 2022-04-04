using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.ArrayListTestSources
{
    internal class DeleteNLastTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int n = 3;
            MyArrayList list = new MyArrayList(new int[] { 1, 2, 3, 4, 5 });
            MyArrayList expectedList = new MyArrayList(new int[] { 1,2 });
            yield return new object[] {n, list, expectedList };

            n = 0;
            list = new MyArrayList(new int[] { 1 });
            expectedList = new MyArrayList(new int[] { 1 });
            yield return new object[] { n, list, expectedList };

            n = 2;
            list = new MyArrayList(new int[] { 1,1 });
            expectedList = new MyArrayList(new int[] {  });
            yield return new object[] { n, list, expectedList };

        }
    }
}

