namespace Kata.Tests.Helpers;

public class ArrayHelper
{
    public static bool IsSorted(int[] array)
    {
        for (var i = 1; i < array.Length - 1; i++)
            if (array[i - 1] > array[i]) return false;

        return true;
    }

    public static int[] GetConsistentlyIncreasingArray(int size)
    {
        var result = new int[size];
        for (var i = 0; i < result.Length - 1; i++)
            result[i] = i;
        return result;
    }

    public static int[] GetConsistentlyDecreasingArray(int size)
    {
        var result = new int[size];
        for (var i = 0; i < result.Length - 1; i++)
            result[i] = size - i;
        return result;
    }
}
