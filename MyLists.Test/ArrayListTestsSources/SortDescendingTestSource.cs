using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Test.ArrayListTestsSources
{
    internal class SortDescendingTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new ArrayList(new int[] { 1, 2, -5, 1, 3 }),
                new ArrayList(new int[] { 3, 2, 1, 1, -5 }),
            };

            yield return new object[]
            {
                new ArrayList(new int[] { 3 }),
                new ArrayList(new int[] { 3 }),
            };

            yield return new object[]
            {
                new ArrayList(new int[] { 0, 0, 0, 0, 0 }),
                new ArrayList(new int[] { 0, 0, 0, 0, 0 }),
            };

            yield return new object[]
            {
                new ArrayList(new int[] { 0, 0, 3, 0, 0 }),
                new ArrayList(new int[] { 3, 0, 0, 0, 0 }),
            };

            yield return new object[]
            {
                new ArrayList(new int[] { }),
                new ArrayList(new int[] { }),
            };
        }
    }
}
