using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.ArrayListTestSources
{
    internal class AddFirstTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 0;
            MyArrayList list = new MyArrayList(new int[] { 1, 2, 3, 4});
            MyArrayList expectedList = new MyArrayList(new int[] { 0, 1, 2, 3, 4 });
            yield return new object[] { value, list, expectedList };


            value = 2;
            list = new MyArrayList(new int[] { 1, 2, 2, });
            expectedList = new MyArrayList(new int[] { 2, 1, 2, 2 });
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

