namespace Kata.Base.Sorting;

public class MergeSortExerciseBase
{
    public virtual void Sort<T>(T[] a) where T : IComparable<T>
    {
        T[] aux = new T[a.Length];
        Sort(a, aux, 0, a.Length - 1);
    }

    protected virtual void Merge<T>(T[] array, T[] aux, int lo, int mid, int hi) where T : IComparable<T>
    {
        int i = lo;
        int j = mid + 1;

        for (var k = lo; k <= hi; k++)
            aux[k] = array[k];

        for (var k = lo; k <= hi; k++)
        {
            if (i > mid) array[k] = aux[j++];
            else if (j > hi) array[k] = aux[i++];
            else if (Less(aux[j], aux[i])) array[k] = aux[j++];
            else array[k] = aux[i++];
        }
    }

    protected virtual void Sort<T>(T[] array, T[] aux, int lo, int hi) where T : IComparable<T>
    {
        if (hi <= lo) return;

        int mid = lo + (hi - lo) / 2;

        Sort(array, aux, lo, mid);
        Sort(array, aux, mid + 1, hi);

        Merge(array, aux, lo, mid, hi);
    }

    protected static bool Less<T>(T v, T w) where T : IComparable<T>
    {
        return v.CompareTo(w) < 0;
    }
}
