using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Test.ArrayListTestsSources
{
    internal class AddListByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new ArrayList(new int[] { 0 }),
                0,
                new ArrayList(new int[] { 5 }),
                new ArrayList(new int[] { 0, 5 }),
            };

            yield return new object[]
            {
                new ArrayList(new int[] { 0 }),
                1,
                new ArrayList(new int[] { 5 }),
                new ArrayList(new int[] { 5, 0 }),
            };

            yield return new object[]
            {
                new ArrayList(new int[] { -10, 11 }),
                2,
                new ArrayList(new int[] { 6, 7, 8, 9 }),
                new ArrayList(new int[] { 6, 7, -10, 11, 8, 9 }),
            };

            yield return new object[]
            {
                new ArrayList(new int[] { -10, 11 }),
                4,
                new ArrayList(new int[] { 6, 7, 8, 9 }),
                new ArrayList(new int[] { 6, 7, 8, 9, -10, 11 }),
            };

            yield return new object[]
            {
                new ArrayList(new int[] { -10, 11 }),
                0,
                new ArrayList(new int[] { 6, 7, 8, 9 }),
                new ArrayList(new int[] { -10, 11, 6, 7, 8, 9 }),
            };

            yield return new object[]
            {
                new ArrayList(new int[] { }),
                1,
                new ArrayList(new int[] { 1, 1 }),
                new ArrayList(new int[] { 1, 1 }),
            };
        }
    }
}
