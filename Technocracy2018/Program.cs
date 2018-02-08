using PerfTestsTools;
using System;

namespace Technocracy2018
{
    class Program
    {
        static void Main(string[] args)
        {
      //Console.WriteLine("string.Concat() vs +");
      //PerfComparer.CompareMethods(
      //    func1: Tests.StringConcatVsPlus.Concat_Using_Concat,
      //    func2: Tests.StringConcatVsPlus.Concat_Using_Plus,
      //    iterations: 100000000);
      //Console.ReadKey();
      ////http://referencesource.microsoft.com/mscorlib/R/55b2f6374a7cf7c1.html

      //Console.WriteLine("string.Concat(params string[]) vs string.Concat(string, string.Concat(string, string, ...))");
      //PerfComparer.CompareMethods(
      //    func1: Tests.StringConcatOverloads.Concat_Using_SlowConcat,
      //    func2: Tests.StringConcatOverloads.Concat_Using_TwoFastConcats,
      //iterations: 100000000);
      //Console.ReadKey();

      //Console.WriteLine("text.Contains('@') vs text.Contains(\"@\")");
      //PerfComparer.CompareMethods(
      //    func1: Tests.ContainsCharVsContainsString.ContainsChar,
      //    func2: Tests.ContainsCharVsContainsString.ContainsString,
      //    iterations: 10000000);
      //Console.ReadKey();
      ////http://referencesource.microsoft.com/mscorlib/R/428c5c9954dea844.html
      ////https://referencesource.microsoft.com/System.Core/R/f60bab4c5e27a849.html

      //Console.WriteLine("text == other_text vs string.Equals(text, other_text, Ordinal)");
      //PerfComparer.CompareMethods(
      //    func1: Tests.StringEqualsVsEqualsOrdinal.Equals,
      //    func2: Tests.StringEqualsVsEqualsOrdinal.EqualsOrdinal,
      //    iterations: 10000000);
      //Console.ReadKey();

      //Console.WriteLine("text1 + text2 vs $\"{text1}{text2}\"");
      //PerfComparer.CompareMethods(
      //    func1: Tests.StringConcatVsInterpolation.Concat,
      //    func2: Tests.StringConcatVsInterpolation.Interpolation,
      //    iterations: 100000000);
      //Console.ReadKey();
      ////https://github.com/dotnet/roslyn/pull/22595
      ////https://referencesource.microsoft.com/mscorlib/R/2c3b4c2e7c43f5a4.html

      //Console.WriteLine("Concat(params object[]) vs Concat(params string[])");
      //PerfComparer.CompareMethods(
      //    func1: Tests.ConcatWithBoxingVsConcatWithoutBoxing.Concat_With_Boxing,
      //    func2: Tests.ConcatWithBoxingVsConcatWithoutBoxing.Concat_Without_Boxing,
      //    iterations: 100000000);
      //Console.ReadKey();
      ////http://referencesource.microsoft.com/mscorlib/R/40825b9a6e8f4b1e.html
      ////http://referencesource.microsoft.com/mscorlib/R/75e4bdc056f3daf0.html

      //Console.WriteLine("list.Any() vs list.Exists()");
      //PerfComparer.CompareMethods(
      //    func1: Tests.AnyVsExists.Any,
      //    func2: Tests.AnyVsExists.Exists,
      //    iterations: 10000000);
      //Console.ReadKey();
      ////https://referencesource.microsoft.com/System.Core/R/8788153112b7ffd0.html Any()
      ////https://referencesource.microsoft.com/mscorlib/R/8280cca4f4bfb6cf.html    Exists()

      //Console.WriteLine("list.Any() vs list.Count > 0");
      //PerfComparer.CompareMethods(
      //    func1: Tests.AnyVsCount0.Any,
      //    func2: Tests.AnyVsCount0.Count0,
      //    iterations: 100000000);
      //Console.ReadKey();
      ////https://referencesource.microsoft.com/mscorlib/R/78a69d857716bc68.html Count

      //Console.WriteLine("iterate List<T> vs IEnumerable<T>");
      //PerfComparer.CompareMethods(
      //    func1: Tests.ListVsIEnumerable.IterateList,
      //    func2: Tests.ListVsIEnumerable.IterateIEnumerable,
      //    iterations: 10000000);
      //Console.ReadKey();

      //Console.WriteLine("throw vs ThrowWrapper");
      //PerfComparer.CompareMethods(
      //    func1: Tests.ThrowVsThrowWrapper.Throw,
      //    func2: Tests.ThrowVsThrowWrapper.ThrowWithWrapper,
      //    iterations: 1000000);
      //Console.ReadKey();
      //https://github.com/dotnet/corefx/issues/26253#issuecomment-356736809
    }
    }
}
