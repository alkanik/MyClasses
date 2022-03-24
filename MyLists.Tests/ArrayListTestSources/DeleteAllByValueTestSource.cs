﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyLists.Tests.ArrayListTestSources
{
    internal class DeleteAllByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 3;
            MyArrayList list = new MyArrayList(new int[] { 1, 2, 3, 4, 5 });
            MyArrayList expectedList = new MyArrayList(new int[] { 1, 2, 4, 5 });
            int expectedNumber = 1;
            yield return new object[] { value, list, expectedList, expectedNumber };


            value = 2;
            list = new MyArrayList(new int[] { 1, 2, 2, 2, 5 });
            expectedList = new MyArrayList(new int[] { 1, 5 });
            expectedNumber = 3;
            yield return new object[] { value, list, expectedList, expectedNumber };


            yield return new object[]
            {
                5,
                new MyArrayList(new int[] { 1, 2, 2 }),
                new MyArrayList(new int[] { 1, 2, 2 }),
                0
            };
        }
    }
}

