using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Test.ArrayListNegativeTestSources
{
    internal class ChangeByIndexNegativeTestSource_WhenListIsEmpty : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                4,
                5,
                new ArrayList(new int[] { }),
            };
        }
    }

    internal class ChangeByIndex_RemoveByIndexNegativeTestSource_WhenIndexOutOfRangeOfList : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                -1,
                new ArrayList(new int[] { 0, 0, 0 })
            };

            yield return new object[]
            {
                6,
                new ArrayList(new int[] { 1, 4, 5, 9, 0, 10 }),
            };

            yield return new object[]
            {
                -1,
                new ArrayList(new int[] { 0 }),
            };

            yield return new object[]
            {
                1,
                new ArrayList(new int[] { 0 }),
            };

            yield return new object[]
            {
                0,
                new ArrayList(new int[] {}),
            };
        }
    }
}
