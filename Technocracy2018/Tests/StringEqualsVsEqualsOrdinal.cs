using System;

namespace Technocracy2018.Tests
{
    public static class StringEqualsVsEqualsOrdinal
    {
        private const string text = "Anixe";

        public static bool Equals()
        {
            return text == "anixe";
        }

        public static bool EqualsOrdinal()
        {
            return string.Equals(text, "anixe", StringComparison.Ordinal);
        }
    }
}
