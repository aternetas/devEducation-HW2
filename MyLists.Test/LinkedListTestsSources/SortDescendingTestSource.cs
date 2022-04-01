using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Test.LinkedListTestsSources
{
    public class SortDescendingTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new LinkedList(new int[] { 7, 8, 9, 10, 11 }),
                new LinkedList(new int[] { 11, 10, 9, 8, 7 }),
            };
        }
    }
}
