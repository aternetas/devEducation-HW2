using System;
using System.Collections;
using NUnit.Framework;
using MyLists.Test.LinkedListTestsSources;

namespace MyLists.Test
{
    public class LinkedListTests
    {
        [TestCaseSource(typeof(InsertTestCaseSource))]
        public void InsertTest(int index, int value, ArrayList list, ArrayList expected)
        {
            list.Insert(index, value);
            ArrayList actual = list;
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(RemoveRangeFromEndTestCaseSource))]
        public void RemoveRangeFromEndTest(int count, ArrayList list, ArrayList expected)
        {
            list.RemoveRangeFromEnd(count);
            ArrayList actual = list;
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(RemoveRangeFromBeginningTestCaseSource))]
        public void RemoveRangeFromBeginningTest(int count, ArrayList list, ArrayList expected)
        {
            list.RemoveRangeFromBeginning(count);
            ArrayList actual = list;
            Assert.AreEqual(expected, actual);
        }
    }
}
