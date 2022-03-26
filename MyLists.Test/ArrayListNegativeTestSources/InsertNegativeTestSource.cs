using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Test.ArrayListNegativeTestSources
{
    internal class InsertNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                5,
                1,
                new ArrayList(new int[] { 0, 0, 0 })
            };

            yield return new object[]
            {
                0,
                5,
                new ArrayList(new int[] { }),
            };

            yield return new object[]
            {
                -1,
                5,
                new ArrayList(new int[] { }),
            };
        }
    }
}
