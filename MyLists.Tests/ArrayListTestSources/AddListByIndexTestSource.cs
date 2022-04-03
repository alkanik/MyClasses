using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.ArrayListTestSources
{
    internal class AddListByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 2;
            MyArrayList list = new MyArrayList(new int[] { 1, 2, 3, 4,5,6,7,8,9,10});
            MyArrayList secondList = new MyArrayList(new int[] { 1, 2 });
            MyArrayList expectedList = new MyArrayList(new int[] { 1, 2, 1,2, 3, 4, 5, 6, 7, 8, 9, 10 });
            yield return new object[] { index, list, secondList, expectedList };

            index = 0;
            list = new MyArrayList(new int[] { 1 });
            secondList = new MyArrayList(new int[] { 5, 6, 7 });
            expectedList = new MyArrayList(new int[] { 5, 6, 7, 1 });
            yield return new object[] { index, list, secondList, expectedList };

            index = 3;
            list = new MyArrayList(new int[] { 1,2,3,4,5,6 });
            secondList = new MyArrayList(new int[] {});
            expectedList = new MyArrayList(new int[] { 1, 2, 3, 4, 5, 6 });
            yield return new object[] { index, list, secondList, expectedList };

        }
    }
}

