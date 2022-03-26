using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Test.ArrayListTestsSources
{
    internal class AddFirstTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                5,
                new ArrayList(new int[] { 0 }),
                new ArrayList(new int[] { 5, 0 }),
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
                new ArrayList(new int[] { 1, 2, 3, 4 }),
                new ArrayList(new int[] { 5, 1, 2, 3, 4 }),
            };
        }
    }
}
