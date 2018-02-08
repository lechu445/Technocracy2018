using System.Collections.Generic;
using System.Linq;

namespace Technocracy2018.Tests
{
    public static class ThrowVsThrowWrapper
    {
        public static void Throw()
        {
            foreach (var item in Enumerable.Range(0, 1000))
            {
                if (item == 1001)
                {
                    throw new System.Exception();
                }
            }
        }

        public static void ThrowWithWrapper()
        {
            foreach (var item in Enumerable.Range(0, 1000))
            {
                if (item == 1001)
                {
                    ThrowWrapper();
                }
            }
        }

        private static void ThrowWrapper()
        {
            throw new System.Exception();
        }
    }
}
