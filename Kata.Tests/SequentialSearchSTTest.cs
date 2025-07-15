using Kata.Exercises;

namespace Kata.Tests;

public class SequentialSearchSTTest {
    [Fact]
    public void TestST() {
        var st = new SequentialSearchST<string, string>();

        Assert.Equal(0, st.Size);
        Assert.True(st.IsEmpty);

        st.Set("D", "Dog");
        st.Set("C", "Cat");
        st.Set("D", "Donkey");

        Assert.Equal(2, st.Size);
        Assert.False(st.IsEmpty);

        Assert.Equal("Cat", st.Get("C"));
        Assert.Equal("Donkey", st.Get("D"));
        Assert.Null(st.Get("X"));
    }
}
