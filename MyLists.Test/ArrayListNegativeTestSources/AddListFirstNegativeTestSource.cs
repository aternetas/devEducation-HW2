using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Test.ArrayListNegativeTestSources
{
    internal class AddListFirstNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                null,
                new ArrayList(new int[] { 5 }),
            };
        }
    }
}
