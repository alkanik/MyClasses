using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.ArrayListTestSources
{
    internal class AddListInTheEndTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            MyArrayList list = new MyArrayList(new int[] { 1, 2, 3, 4});
            MyArrayList secondList = new MyArrayList(new int[] { 5,6,7 });
            MyArrayList expectedList = new MyArrayList(new int[] { 1, 2, 3, 4,5,6,7  });
            yield return new object[] { list, secondList, expectedList };

            list = new MyArrayList(new int[] { });
            secondList = new MyArrayList(new int[] { 5, 6, 7 });
            expectedList = new MyArrayList(new int[] { 5, 6, 7 });
            yield return new object[] { list, secondList, expectedList };

            list = new MyArrayList(new int[] {1,2,3 });
            secondList = new MyArrayList(new int[] {  });
            expectedList = new MyArrayList(new int[] { 1,2,3});
            yield return new object[] { list, secondList, expectedList };

        }
    }
}

