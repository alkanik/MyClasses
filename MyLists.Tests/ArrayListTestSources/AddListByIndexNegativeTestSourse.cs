using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.ArrayListTestSources
{
    internal class AddListByIndexNegativeTestSourse : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = -1;
            MyArrayList list = new MyArrayList(new int[] { 1, 2, 3, 4,5,6,7,8,9,10});
            MyArrayList secondList = new MyArrayList(new int[] { 1, 2 });
            yield return new object[] { index, list, secondList };

            index = 5;
            list = new MyArrayList(new int[] { 1 });
            secondList = new MyArrayList(new int[] { 5, 6, 7 });
            yield return new object[] { index, list, secondList };
        }
    }
}

