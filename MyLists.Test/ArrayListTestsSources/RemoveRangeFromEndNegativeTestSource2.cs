using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Test.ArrayListTestsSources
{
    internal class RemoveRangeFromEnd_RemoveRangeFromBeginningNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                4,
                new ArrayList(new int[] { 1, 3, 4, 4 })
            };

            yield return new object[]
            {
                -1,
                new ArrayList(new int[] { 1, 3, 4, 4 })
            };

            yield return new object[]
            {
                2,
                new ArrayList(new int[] { 1 })
            };
        }
    }
}
