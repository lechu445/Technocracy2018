namespace Technocracy2018.Tests
{
    public static class StringConcatVsInterpolation
    {
        private static string text1 = "text1";
        private static string text2 = "text2";

        public static string Concat()
        {
            return text1 + text2;
        }

        public static string Interpolation()
        {
            return $"{text1}{text2}";
        }
    }
}
