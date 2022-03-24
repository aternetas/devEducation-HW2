using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Test.ArrayListTestsSources
{
    internal class RemoveByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                0,
                new ArrayList(new int[] { 5 }),
                new ArrayList(new int[] { }),
            };

            yield return new object[]
            {
                1,
                new ArrayList(new int[] { -2, 3, 4, 5 }),
                new ArrayList(new int[] { -2, 4, 5 }),
            };

            yield return new object[]
            {
                5,
                new ArrayList(new int[] { 0, 1, 3, 6, -5, 4 }),
                new ArrayList(new int[] { 0, 1, 3, 6, -5 }),
            };
        }
    }
}
