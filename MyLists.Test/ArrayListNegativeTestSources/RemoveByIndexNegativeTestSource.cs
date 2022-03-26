using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Test.ArrayListNegativeTestSources
{
    internal class RemoveByIndexNegativeTestSource_WhenListIsEmpty : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                4,
                new ArrayList(new int[] {})
            };
        }
    }

    internal class RemoveByIndexNegativeTestSource_WhenIndexOutOfRange : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                4,
                new ArrayList(new int[] { 3 })
            };

            yield return new object[]
            {
                3,
                new ArrayList(new int[] { 0, 0, 0 })
            };

            yield return new object[]
            {
                -1,
                new ArrayList(new int[] { 0, 0, 0 })
            };
        }
    }
}
