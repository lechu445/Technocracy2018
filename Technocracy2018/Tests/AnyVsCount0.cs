using System.Collections.Generic;
using System.Linq;

namespace Technocracy2018.Tests
{
    public static class AnyVsCount0
    {
        private static List<int> list = new List<int>(Enumerable.Range(0, 100));

        public static bool Any()
        {
            return list.Any();
        }

        public static bool Count0()
        {
            return list.Count > 0;
        }
    }
}
