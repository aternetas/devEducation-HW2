using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Test.ArrayListTestsSources
{
    internal class AddLastTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                5,
                new ArrayList(new int[] { 0 }),
                new ArrayList(new int[] { 0, 5 }),
            };

            yield return new object[]
            {
                5,
                new ArrayList(new int[] {}),
                new ArrayList(new int[] { 5 }),
            };

            yield return new object[]
            {
                5,
                new ArrayList(new int[] { 1, -5, 2, 0, 1 }),
                new ArrayList(new int[] { 1, -5, 2, 0, 1, 5 }),
            };
        }
    }
}
