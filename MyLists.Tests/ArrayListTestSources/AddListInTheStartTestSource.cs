using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.ArrayListTestSources
{
    internal class AddListInTheStartTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            MyArrayList list = new MyArrayList(new int[] { 1, 2, 3, 4,5,6,7,8,9,10});
            MyArrayList secondList = new MyArrayList(new int[] { 11,12 });
            MyArrayList expectedList = new MyArrayList(new int[] { 11,12,1, 2, 3, 4,5,6,7,8,9,10 });
            yield return new object[] { list, secondList, expectedList };

            list = new MyArrayList(new int[] { });
            secondList = new MyArrayList(new int[] { 5, 6, 7 });
            expectedList = new MyArrayList(new int[] { 5, 6, 7 });
            yield return new object[] { list, secondList, expectedList };

            list = new MyArrayList(new int[] {1,2,3 });
            secondList = new MyArrayList(new int[] {  });
            expectedList = new MyArrayList(new int[] { 1,2,3});
            yield return new object[] { list, secondList, expectedList };

            list = new MyArrayList(new int[] { });
            secondList = new MyArrayList(new int[] { });
            expectedList = new MyArrayList(new int[] { });
            yield return new object[] { list, secondList, expectedList };

        }
    }
}

