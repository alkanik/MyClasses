using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.ArrayListTestSources
{
    internal class ChangeValueByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 3;
            int value = 1;
            MyArrayList list = new MyArrayList(new int[] { 1, 2, 3, 4, 5 });
            MyArrayList expectedList = new MyArrayList(new int[] { 1, 2, 3, 1, 5 });
            yield return new object[] {index,value, list, expectedList };

            index = 0;
            value = 5;
            list = new MyArrayList(new int[] { 1 });
            expectedList = new MyArrayList(new int[] { 5 });
            yield return new object[] { index,value, list, expectedList };

            index = 2;
            value = 1;
            list = new MyArrayList(new int[] { 1,1,1,1,1 });
            expectedList = new MyArrayList(new int[] { 1, 1, 1, 1, 1 });
            yield return new object[] { index,value, list, expectedList };

        }
    }
}

