using System.Collections.Generic;
using System.Linq;

namespace Technocracy2018.Tests
{
    public static class AnyVsExists
    {
        private static List<int> list = new List<int>(Enumerable.Range(0, 100));

        public static bool Any()
        {
            return list.Any(item => item == 70);
        }

        public static bool Exists()
        {
            return list.Exists(item => item == 70);
        }
    }
}
