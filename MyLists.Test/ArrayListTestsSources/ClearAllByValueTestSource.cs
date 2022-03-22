using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Test.ArrayListTestsSources
{
    internal class ClearAllByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                4,
                new ArrayList(new int[] { 1, 2, -5, 1, 3 }),
                new ArrayList(new int[] { 1, 2, -5, 1, 3 }),
                0
            };

            yield return new object[]
            {
                3,
                new ArrayList(new int[] { 3, 1, 3, 2, 3, -5, 1, 3 }),
                new ArrayList(new int[] { 1, 2, -5, 1 }),
                4
            };

            yield return new object[]
            {
                0,
                new ArrayList(new int[] { 0, 0, 0, 0, 0 }),
                new ArrayList(new int[] { }),
                5
            };
        }
    }
}
