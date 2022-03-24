using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Test.ArrayListTestsSources
{
    internal class ChangeByIndexNegativeTestSource1 : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                4,
                5,
                new ArrayList(new int[] { }),
            };
        }
    }
}
