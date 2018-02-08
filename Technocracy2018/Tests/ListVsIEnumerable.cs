using System.Collections.Generic;
using System.Linq;

namespace Technocracy2018.Tests
{
    public static class ListVsIEnumerable
    {
        private static List<int> list = new List<int>(Enumerable.Range(0, 100));

        public static int IterateList()
        {
            return FindMaxInList(list);
        }

        public static int IterateIEnumerable()
        {
            return FindMaxInEnumerable(list);
        }

        private static int FindMaxInList(IList<int> list)
        {
            int max = -1;
            foreach (var item in list)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }

        private static int FindMaxInEnumerable(List<int> list)
        {
            int max = -1;
            foreach (var item in list)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }
    }
}
