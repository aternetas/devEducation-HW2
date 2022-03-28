using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Test.ArrayListNegativeTestSources
{
    internal class RemoveRangeFromBeginningNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                4,
                new ArrayList(new int[] { })
            };
        }
    }
}
