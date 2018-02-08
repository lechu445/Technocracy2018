namespace Technocracy2018.Tests
{
    public static class StringConcatOverloads
    {
        private static string text1 = "text1";
        private static string text2 = "text2";
        private static string text3 = "text3";
        private static string text4 = "text4";
        private static string text5 = "text5";

        public static string Concat_Using_SlowConcat()
        {
            return string.Concat(text1, text2, text3, text4, text5);
        }

        public static string Concat_Using_TwoFastConcats()
        {
            return string.Concat(text1, string.Concat(text2, text3, text4, text5));
        }
    }
}
