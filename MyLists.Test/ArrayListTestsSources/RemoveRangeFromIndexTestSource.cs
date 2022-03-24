using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Test.ArrayListTestsSources
{
    internal class RemoveRangeFromIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                0,
                0,
                new ArrayList(new int[] { 5 }),
                new ArrayList(new int[] { 5 }),
            };

            yield return new object[]
            {
                1,
                3,
                new ArrayList(new int[] { -2, 3, 4, 5 }),
                new ArrayList(new int[] { -2, 3, 4 }),
            };

            yield return new object[]
            {
                5,
                2,
                new ArrayList(new int[] { 0, 1, 3, 6, -5, 4, 7, 9, 13, -20, 18 }),
                new ArrayList(new int[] { 0, 1, 9, 13, -20, 18 }),
            };
        }
    }
}
