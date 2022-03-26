using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Test.ArrayListTestsSources
{
    internal class AddListFirstTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new ArrayList(new int[] { 0 }),
                new ArrayList(new int[] { 5 }),
                new ArrayList(new int[] { 0, 5 }),
            };

            yield return new object[]
            {
                new ArrayList(new int[] { -10, 11 }),
                new ArrayList(new int[] { 6, 7 }),
                new ArrayList(new int[] { -10, 11, 6, 7 }),
            };

            yield return new object[]
            {
                new ArrayList(new int[] { }),
                new ArrayList(new int[] { 1, 1 }),
                new ArrayList(new int[] { 1, 1 }),
            };
        }
    }
}
