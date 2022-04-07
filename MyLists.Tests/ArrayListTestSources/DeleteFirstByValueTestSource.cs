using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.ArrayListTestSources
{
    internal class DeleteFirstByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 3;
            MyArrayList list = new MyArrayList(new int[] { 1, 2, 3,3, 4, 5 });
            MyArrayList expectedList = new MyArrayList(new int[] { 1, 2,3, 4, 5 });
            int expectedIndex = 2;
            yield return new object[] { value, list, expectedList, expectedIndex };


            value = 2;
            list = new MyArrayList(new int[] { 1, 2, 5 });
            expectedList = new MyArrayList(new int[] { 1, 5 });
            expectedIndex = 1;
            yield return new object[] { value, list, expectedList, expectedIndex };


            yield return new object[]
            {
                5,
                new MyArrayList(new int[] { 1, 2, 2 }),
                new MyArrayList(new int[] { 1, 2, 2 }),
                -1
            };
        }
    }
}

