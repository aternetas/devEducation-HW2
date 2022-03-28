using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Test.LinkedListTestsSources
{
    public class InsertTestCaseSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                3,
                10,
                new ArrayList(new int[] { 1, 2, 3, 4, 5 }),
                new ArrayList(new int[] { 1, 2, 3, 10, 4, 5 })
            };

            yield return new object[]
            {
                0,
                10,
                new ArrayList(new int[] { 1, 2, 3, 4, 5 }),
                new ArrayList(new int[] { 10, 1, 2, 3, 4, 5 })
            };
        }
    }
}
