using JetBrains.Annotations;
using Kata.Exercises.Strings;

namespace Kata.Tests.Strings;

[TestSubject(typeof(LeastSignificantDigitSorting))]
public class LeastSignificantDigitSortingTest {
    [Theory]
    [InlineData(new[] {
        // ReSharper disable StringLiteralTypo
        "DITXJVC", "ONRC2AY", "U6UK8Z6", "IP3QTTQ", "AJYFQOT", "VSTYRV8", "BBWZTPW", "XE9A192", "U451EH7",
        "WIWB0IL", "91T3A9F", "CQ473VM", "YSQOXB4", "DWWGIYQ", "NAGT2D3", "R3FBK6F", "40Z63W8", "TAB1BIG",
    }, new[] {
        "40Z63W8", "91T3A9F", "AJYFQOT", "BBWZTPW", "CQ473VM", "DITXJVC", "DWWGIYQ", "IP3QTTQ", "NAGT2D3",
        "ONRC2AY", "R3FBK6F", "TAB1BIG", "U451EH7", "U6UK8Z6", "VSTYRV8", "WIWB0IL", "XE9A192", "YSQOXB4",
        // ReSharper restore StringLiteralTypo
    })]
    public void TestSort(string[] input, string[] expected) {
        LeastSignificantDigitSorting.Sort(input, 7, 256);
        Assert.Equal(expected, input);
    }
}
