using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Test.LinkedListTestsSources
{
    public class RemoveRangeFromBeginningTestCaseSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                2,
                new ArrayList(new int[] { 1, 2, 3, 4, 5 }),
                new ArrayList(new int[] { 3, 4, 5 })
            };

            yield return new object[]
            {
                5,
                new ArrayList(new int[] { 1, 2, 3, 4, 5 }),
                new ArrayList(new int[] { })
            };

            yield return new object[]
            {
                4,
                new ArrayList(new int[] { 1, 2, 3, 4, 5 }),
                new ArrayList(new int[] { 5 })
            };

            yield return new object[]
            {
                0,
                new ArrayList(new int[] { 1, 2, 3, 4, 5 }),
                new ArrayList(new int[] { 1, 2, 3, 4, 5 })
            };
        }
    }
}
