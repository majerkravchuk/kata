using JetBrains.Annotations;
using Kata.Exercises.Arrays;

namespace Kata.Tests.Arrays;

[TestSubject(typeof(ReverseArray))]
public class ReverseArrayTest
{
    [Theory]
    [InlineData(
        new[] { 2, 1 },
        new[] { 1, 2 })]
    [InlineData(
        new[] { 9, 3, 4 },
        new[] { 4, 3, 9 })]
    [InlineData(
        new[] { 9, 3, 7, 4, 69, 420, 42 },
        new[] { 42, 420, 69, 4, 7, 3, 9 })]
    public void TestIndexOf(int[] input, int[] reversed)
    {
        ReverseArray.Reverse(input);
        Assert.Equal(reversed, input);
    }
}
