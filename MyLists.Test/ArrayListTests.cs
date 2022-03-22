using NUnit.Framework;
using System.Collections;
using MyLists.Test.ArrayListTestsSources;

namespace MyLists.Test
{
    public class ArrayListTests
    {
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