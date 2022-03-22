using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Test.ArrayListTestsSources
{
    internal class InsertTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                0,
                5,
                new ArrayList(new int[] { }),
                new ArrayList(new int[] { 5 }),
            };

            yield return new object[]
            {
                1,
                5,
                new ArrayList(new int[] { 2, 3 }),
                new ArrayList(new int[] { 2, 5, 3 }),
            };

            yield return new object[]
            {
                5,
                3,
                new ArrayList(new int[] { 0, 0 }),
                new ArrayList(new int[] { 0, 0, 0, 0, 0, 3 }),
            };
        }
    }
}
