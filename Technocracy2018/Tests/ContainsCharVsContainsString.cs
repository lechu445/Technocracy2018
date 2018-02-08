using System.Linq;

namespace Technocracy2018.Tests
{
    public static class ContainsCharVsContainsString
    {
        public const string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
            "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, " +
            "quis nostrud @ exercitation ullamco";

        public static bool ContainsChar()
        {
            return text.Contains('@');
        }

        public static bool ContainsString()
        {
            return text.Contains("@");
        }
    }
}
