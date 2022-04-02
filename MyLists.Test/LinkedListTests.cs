using System;
using System.Collections;
using NUnit.Framework;
using MyLists.Test.LinkedListTestsSources;

namespace MyLists.Test
{
    public class LinkedListTests
    {

        [TestCaseSource(typeof(AddLastTestSource))]
        public void AddLastTest(int value, IMyList list, IMyList expected)
        {
            list.AddLast(value);
            IMyList actual = list;
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(RemoveByIndexTestSource))]
        public void RemoveByIndexTest(int index, LinkedList list, LinkedList expected)
        {
            list.RemoveByIndex(index);
            Assert.AreEqual(expected, list);
        }

        [TestCaseSource(typeof(RemoveRangeFromIndexTestSource))]
        public void RemoveRangeFromIndexTest(int index, int count, LinkedList list, LinkedList expected)
        {
            list.RemoveRangeFromIndex(index, count);
            Assert.AreEqual(expected, list);
        }

        [TestCaseSource(typeof(ReverseTestSource))]
        public void ReverseTest(LinkedList list, LinkedList expected)
        {
            list.Reverse();
            Assert.AreEqual(expected, list);
        }

        [TestCaseSource(typeof(FindMaxValueTestSource))]
        public void FindMaxValueTest(LinkedList list, int expected)
        {
            int actual = list.FindMaxValue();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(SortDescendingTestSource))]
        public void SortDescendingTest(LinkedList list, LinkedList expected)
        {
            list.SortDescending();
            Assert.AreEqual(expected, list);
        }

        [TestCaseSource(typeof(AddListLastTestSource))]
        public void AddListLastTest(LinkedList list, LinkedList actual, LinkedList expected)
        {
            actual.AddListLast(list);
            Assert.AreEqual(expected, actual);
        }
    }
}
