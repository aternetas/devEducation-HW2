using NUnit.Framework;
using System.Collections;
using System;
using MyLists.Test.ArrayListTestsSources;
using MyLists.Test.ArrayListNegativeTestSources;

namespace MyLists.Test
{
    public class ArrayListTests
    {
        [TestCaseSource(typeof(AddLastTestSource))]
        public void AddLastTest(int value, ArrayList list, ArrayList expectedList)
        {
            list.AddLast(value);
            ArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddFirstTestSource))]
        public void AddFirstTest(int value, ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(InsertTestSource))]
        public void InsertTest(int index, int value, ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(RemoveLastTestSource))]
        public void RemoveLastTest(ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [Test]
        public void RemoveLastTest_WhenListIsEmpty_ShouldThrowException()
        {
            ArrayList list = new ArrayList();
            Assert.Throws<Exception>(() => list.RemoveLast());
        }

        [TestCaseSource(typeof(RemoveFirstTestSource))]
        public void RemoveFirstTest(ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(RemoveByIndexTestSource))]
        public void RemoveByIndexTest(int index, ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(RemoveRangeFromEndTestSource))]
        public void RemoveRangeFromEndTest(int count, ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(RemoveRangeFromEndNegativeTestSource))]
        public void RemoveRangeFromEndTest_WhenListIsEmpty_ShouldThrowException(int count, ArrayList list)
        {
            Assert.Throws<Exception>(() => list.RemoveRangeFromEnd(count));
        }

        [TestCaseSource(typeof(RemoveRangeFromEnd_RemoveRangeFromBeginningNegativeTestSource))]
        public void RemoveRangeFromEndTest_RemoveRangeFromBeginningTest_WhenCountBiggerLenghtOrCountIsLessZero_ShouldThrowException(int count, ArrayList list)
        {
            int a;
            Assert.Throws<Exception>(() => a = list.Lenght);
        }

        [TestCaseSource(typeof(RemoveRangeFromBeginninTestSource))]
        public void RemoveRangeFromBeginningTest(int count, ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(RemoveRangeFromBeginningNegativeTestSource))]
        public void RemoveRangeFromBeginningTest_WhenListIsEmpty_ShouldThrowException(int count, ArrayList list)
        {
            Assert.Throws<Exception>(() => list.RemoveRangeFromBeginning(count));
        }

        [TestCaseSource(typeof(RemoveRangeFromIndexTestSource))]
        public void RemoveRangeFromIndexTest(int count, int index, ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [Test]
        public void RemoveRangeFromIndexTest_WhenListIsEmpty_ShouldThrowException(int count, int index)
        {
            ArrayList list = new ArrayList();
            Assert.Throws<Exception>(() => list.RemoveRangeFromIndex(count, index));
        }

        [TestCaseSource(typeof(RemoveRangeFromIndexNegativeTestSource))]
        public void RemoveRangeFromIndexTest_WhenCountBiggerLenghtOrCountIsLessZero_ShouldThrowException(int count, int index, ArrayList list)
        {
            Assert.Throws<Exception>(() => list.RemoveRangeFromIndex(count, index));
        }

        [TestCaseSource(typeof(GetLenghtTestSource))]
        public void GetLenghtTest(ArrayList list, int expected)
        {
            int actual = list.GetLenght();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(GetValueTestSource))]
        public void GetValueTest(int index, ArrayList list, int expected)
        {
            int actual = list.GetValue(index);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(ReturnFirstIndexTestSource))]
        public void ReturnFirstIndexTest(int value, ArrayList list, int expected)
        {
            int actual = list.ReturnFirstIndex(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(ChangeByIndexTestSource))]
        public void ChangeByIndexTest(int index, int value, ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ChangeByIndexNegativeTestSource))]
        public void ChangeByIndexTest_WhenListIsEmpty_ShouldThrowException(int index, int value, ArrayList list)
        {
            Assert.Throws<Exception>(()=> list.ChangeByIndex(index, value));
        }

        [TestCaseSource(typeof(ChangeByIndex_RemoveByIndexNegativeTestSource))]
        public void ChangeByIndex_RemoveByIndex_WhenIndexOutOfRangeOfList_ShouldThrowIndexOutOfRangeException(int index, ArrayList list)
        {
            int a;
            Assert.Throws<IndexOutOfRangeException>(() => a = list[index]);
        }

        [TestCaseSource(typeof(ReverseTestSource))]
        public void ReverseTest(ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(FindMaxValueTestSource))]
        public void FindMaxValueTest(ArrayList list, int expected)
        {
            int actual = list.FindMaxValue();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindMaxValueTest_WhenListIsEmpty_ShouldThrowException()
        {
            ArrayList list = new ArrayList();
            Assert.Throws<Exception>(() => list.FindMaxValue());
        }

        [TestCaseSource(typeof(FindMinValueTestSource))]
        public void FindMinValueTest(ArrayList list, int expected)
        {
            int actual = list.FindMinValue();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindMinValueTest_WhenListIsEmpty_ShouldThrowException()
        {
            ArrayList list = new ArrayList();
            Assert.Throws<Exception>(() => list.FindMinValue());
        }

        [TestCaseSource(typeof(FindIndexOfMaxValueTestSource))]
        public void FindIndexOfMaxValueTest(ArrayList list, int expected)
        {
            int actual = list.FindIndexOfMaxValue();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindIndexOfMaxValueTest_WhenListIsEmpty_ShouldThrowException()
        {
            ArrayList list = new ArrayList();
            Assert.Throws<Exception>(() => list.FindIndexOfMaxValue());
        }

        [TestCaseSource(typeof(FindIndexOfMinValueTestSource))]
        public void FindIndexOfMinValueTest(ArrayList list, int expected)
        {
            int actual = list.FindIndexOfMinValue();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindIndexOfMinValueTest_WhenListIsEmpty_ShouldThrowException()
        {
            ArrayList list = new ArrayList();
            Assert.Throws<Exception>(() => list.FindIndexOfMinValue());
        }

        [TestCaseSource(typeof(SortAscendingTestSource))]
        public void SortAscendingTest(ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(SortDescendingTestSource))]
        public void SortDescendingTest(ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ClearFirstValueTestSource))]
        public void ClearFirstValueTest(int value, ArrayList list, ArrayList expectedList, int expectedIndex)
        {
            int actualIndex = list.ClearFirstValue(value);
            ArrayList actualList = list;
            Assert.AreEqual(expectedIndex, actualIndex);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ClearAllByValueTestSource))]
        public void ClearAllByValueTest(int value, ArrayList list, ArrayList expectedList, int expectedCount)
        {
            int actualCount = list.ClearAllByValue(value);
            ArrayList actualList = list;
            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListLastTestSource))]
        public void AddListLastTest(ArrayList list, ArrayList actualList, ArrayList expectedList)
        {
            actualList.AddListLast(list);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListLastNegativeTestSource))]
        public void AddListLastTest_WhenListIsNull_ThrowNullReferenceException(ArrayList list, ArrayList actualList)
        {
            Assert.Throws<NullReferenceException>(() => actualList.AddListLast(list));
        }


        [TestCaseSource(typeof(AddListFirstTestSource))]
        public void AddListFirstTest(ArrayList list, ArrayList actualList, ArrayList expectedList)
        {
            actualList.AddListFirst(list);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListFirstNegativeTestSource))]
        public void AddListFirstTest_WhenListIsNull_ThrowNullReferenceException(ArrayList list, ArrayList actualList)
        {
            Assert.Throws<NullReferenceException>(() => actualList.AddListFirst(list));
        }

        [TestCaseSource(typeof(AddListByIndexTestSource))]
        public void AddListByIndexTest(ArrayList list, int index, ArrayList actualList, ArrayList expectedList)
        {
            actualList.AddListByIndex(list, index);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListByIndexNegativeTestSource))]
        public void AddListByIndexTest_WhenListIsNull_ThrowNullReferenceException(ArrayList list, int index, ArrayList actualList)
        {
            Assert.Throws<NullReferenceException>(() => actualList.AddListByIndex(list, index));
        }
    }
}