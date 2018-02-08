namespace Technocracy2018.Tests
{
    public static class StringConcatVsPlus
    {
        private const string text1 = "text1";
        private const string text2 = "text2";

        public static string Concat_Using_Concat()
        {
            return string.Concat(text1, text2);
        }

        public static string Concat_Using_Plus()
        {
            return text1 + text2;
        }
    }
}
