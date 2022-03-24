using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Test.ArrayListTestsSources
{
    internal class ChangeByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                4,
                5,
                new ArrayList(new int[] { 1, 2, -5, 1, 3 }),
                new ArrayList(new int[] { 1, 2, -5, 1, 5 }),
            };

            yield return new object[]
            {
                1,
                3,
                new ArrayList(new int[] { 3, 1, 3, 2, 3, -5, 1, 3 }),
                new ArrayList(new int[] { 3, 3, 3, 2, 3, -5, 1, 3 }),
            };

            yield return new object[]
            {
                0,
                0,
                new ArrayList(new int[] { 0, 0, 0, 0, 0 }),
                new ArrayList(new int[] { 0, 0, 0, 0, 0 }),
            };
        }
    }
}
