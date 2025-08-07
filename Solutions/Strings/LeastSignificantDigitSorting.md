```c#
public static class LeastSignificantDigitSorting {
    public static void Sort(string[] strings, int w, int r) {
        var n = strings.Length;
        var aux = new string[n];

        for (var d = w - 1; d >= 0; d--) {
            var count = new int[r + 1];

            for (var i = 0; i < n; i++) count[strings[i][d] + 1]++;
            for (var i = 0; i < r; i++) count[i + 1] += count[i];
            for (var i = 0; i < n; i++) aux[count[strings[i][d]]++] = strings[i];
            for (var i = 0; i < n; i++) strings[i] = aux[i];
        }
    }
}
```
