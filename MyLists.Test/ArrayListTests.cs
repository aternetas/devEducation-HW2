using NUnit.Framework;
using System.Collections;
using MyLists.Test.ArrayListTestsSources;

namespace MyLists.Test
{
    public class ArrayListTests
    {
        [TestCaseSource(typeof(AddLastTestSource))]
        public void AddLastTest(int value, ArrayList list, ArrayList expectedList)
        {
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

        [TestCaseSource(typeof(RemoveFirstTestSource))]
        public void RemoveFirstTest(ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
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

        [TestCaseSource(typeof(ClearFirstValueTestSource))]
        public void ClearFirstValueTest(int value, ArrayList list, ArrayList expectedList, int extectedIndex)
        {
            int actualIndex = list.ClearFirstValue(value);
            ArrayList actualList = list;
            Assert.AreEqual(extectedIndex, actualIndex);
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
    }
}