using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Test.ArrayListTestsSources
{
    internal class ReturnFirstIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                3,
                new ArrayList(new int[] { 0 }),
                -1
            };

            yield return new object[]
            {
                3,
                new ArrayList(new int[] {}),
                -1                
            };

            yield return new object[]
            {
                2,
                new ArrayList(new int[] { 1, -5, 0, 2, 1 }),
                3
            };

            yield return new object[]
            {
                4,
                new ArrayList(new int[] { 1, -5, 0, 2, 1, 4, 4, 4 }),
                5
            };
        }
    }
}
