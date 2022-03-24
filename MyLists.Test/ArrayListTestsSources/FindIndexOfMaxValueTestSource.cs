using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Test.ArrayListTestsSources
{
    internal class FindIndexOfMaxValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new ArrayList(new int[] { 0 }),
                0
            };

            yield return new object[]
            {
                new ArrayList(new int[] { 1, -5, 2, 7, 4 }),
                3
            };

            yield return new object[]
            {
                new ArrayList(new int[] { 1, 1, 2, 1, 1, 1 }),
                2
            };

            yield return new object[]
            {
                new ArrayList(new int[] { 0, 0, 0, 0, 0, 0 }),
                0
            };
        }
    }
}
