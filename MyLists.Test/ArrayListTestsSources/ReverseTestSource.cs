using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Test.ArrayListTestsSources
{
    internal class ReverseTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new ArrayList(new int[] { 0 }),
                new ArrayList(new int[] { 0 }),
            };

            yield return new object[]
            {
                new ArrayList(new int[] {}),
                new ArrayList(new int[] {}),
            };

            yield return new object[]
            {
                new ArrayList(new int[] { 1, -5, 2, 0, 1 }),
                new ArrayList(new int[] { 1, 0, 2, -5, 1 }),
            };

            yield return new object[]
            {
                new ArrayList(new int[] { 1, -5, 2, 0, 1, 7 }),
                new ArrayList(new int[] { 7, 1, 0, 2, -5, 1 }),
            };
        }
    }
}
