namespace Kata.Base.BinarySearch;

public class BinarySearchExerciseBase
{
    public virtual int IndexOf<T>(T[] array, T value) where T : IComparable<T>
    {
        var lo = 0;
        var hi = array.Length - 1;

        while (lo <= hi)
        {
            var mid = lo + ((hi - lo) >> 1);
            var cmp = value.CompareTo(array[mid]);

            if (cmp < 0)
                hi = mid - 1;
            else if (cmp > 0)
                lo = mid + 1;
            else
                return mid;
        }

        return -1;
    }
}
