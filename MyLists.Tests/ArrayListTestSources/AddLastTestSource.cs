using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.ArrayListTestSources
{
    internal class AddLastTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 5;
            MyArrayList list = new MyArrayList(new int[] { 1, 2, 3, 4});
            MyArrayList expectedList = new MyArrayList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { value, list, expectedList };


            value = 2;
            list = new MyArrayList(new int[] { 1, 2, 2, });
            expectedList = new MyArrayList(new int[] { 1, 2, 2, 2 });
            yield return new object[] { value, list, expectedList };


            yield return new object[]
            {
                5,
                new MyArrayList(new int[] {  }),
                new MyArrayList(new int[] { 5 }),
            };
        }
    }
}

