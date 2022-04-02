using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Test.LinkedListTestsSources
{
    public class AddLastTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                4,
                new LinkedList(new int[] { 1, 2, 3 }),
                new LinkedList(new int[] { 1, 2, 3, 4 })
            };
        }
    }
}
