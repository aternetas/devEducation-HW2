using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Test.LinkedListTestsSources
{
    public class FindMaxValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new LinkedList(new int[] { 1, 2, 3, 4, 5 }),
                5
            };

            yield return new object[]
            {
                new LinkedList(new int[] { 0, 0, 0 }),
                0
            };

            yield return new object[]
            {
                new LinkedList(new int[] { 0, 0, 3, 0, 0 }),
                3
            };

            yield return new object[]
            {
                new LinkedList(new int[] { 1, 2, 4, 0, 4, -3, 4, 3 }),
                4
            };
        }
    }
}
