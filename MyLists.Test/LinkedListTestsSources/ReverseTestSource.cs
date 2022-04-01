using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Test.LinkedListTestsSources
{
    public class ReverseTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new LinkedList(new int[] { 1, 2, 3, 4, 5 }),
                new LinkedList(new int[] { 5, 4, 3, 2, 1 }),
            };
        }
    }
}
