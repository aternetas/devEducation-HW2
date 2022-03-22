using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Test.ArrayListTestsSources
{
    internal class ClearFirstValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                2,
                new ArrayList(new int[] { 0, 1, 2, 3, 4, 5 }),
                new ArrayList(new int[] { 0, 1, 3, 4, 5 }),
                2
            };

            yield return new object[]
            {
                3,
                new ArrayList(new int[] { 9, -1, 0, 2, 1, 3 }),
                new ArrayList(new int[] { 9, -1, 0, 2, 1 }),
                5
            };

            yield return new object[]
            {
                0,
                new ArrayList(new int[] { 0, 0, 0, 0, 0 }),
                new ArrayList(new int[] { 0, 0, 0, 0 }),
                0
            };

            yield return new object[]
            {
                6,
                new ArrayList(new int[] { 3, 0, 10, 2, 0 }),
                new ArrayList(new int[] { 3, 0, 10, 2, 0 }),
                -1
            };

            yield return new object[]
            {
                5,
                new ArrayList(new int[] { 5 }),
                new ArrayList(new int[] {}),
                0
            };
        }
    }
}
