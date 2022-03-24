using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Test.ArrayListTestsSources
{
    internal class RemoveRangeFromIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                4,
                2,
                new ArrayList(new int[] { 1, 3, 4, 4 })
            };

            yield return new object[]
            {
                1,
                2,
                new ArrayList(new int[] { 1 })
            };
        }
    }
}
