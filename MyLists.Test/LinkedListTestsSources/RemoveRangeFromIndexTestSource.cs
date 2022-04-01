using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Test.LinkedListTestsSources
{
    public class RemoveRangeFromIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                1,
                2,
                new LinkedList(new int[] { 1, 2, 3, 4, 5 }),
                new LinkedList(new int[] { 1, 4, 5 })
            };

            yield return new object[]
            {
                2,
                1,
                new LinkedList(new int[] { 1, 2, 3, 4, 5 }),
                new LinkedList(new int[] { 1, 2, 4, 5 })
            };

            yield return new object[]
            {
                0,
                4,
                new LinkedList(new int[] { 1, 2, 3, 4, 5 }),
                new LinkedList(new int[] { 5 })
            };

            yield return new object[]
            {
                1,
                4,
                new LinkedList(new int[] { 1, 2, 3, 4, 5 }),
                new LinkedList(new int[] { 1 })
            };
        }
    }
}
