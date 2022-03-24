using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Test.ArrayListTestsSources
{
    internal class ChangeByIndex_RemoveByIndexNegativeTestSource : IEnumerable
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
