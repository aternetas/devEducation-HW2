using System;
using System.Collections;
using NUnit.Framework;
using MyLists.Test.LinkedListTestsSources;

namespace MyLists.Test
{
    public class LinkedListTests
    {
        [TestCaseSource(typeof(InsertTestCaseSource))]
        public void InsertTest(int index, int value, LinkedList list, LinkedList expected)
        {
            list.Insert(index, value);
            LinkedList actual = list;
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(RemoveRangeFromEndTestCaseSource))]
        public void RemoveRangeFromEndTest(int count, LinkedList list, LinkedList expected)
        {
            list.RemoveRangeFromEnd(count);
            LinkedList actual = list;
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(RemoveRangeFromBeginningTestCaseSource))]
        public void RemoveRangeFromBeginningTest(int count, LinkedList list, LinkedList expected)
        {
            list.RemoveRangeFromBeginning(count);
            LinkedList actual = list;
            Assert.AreEqual(expected, actual);
        }
    }
}
