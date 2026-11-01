using ClassLibrary;

public static class EnumerableExtensions
{
    // R1
    public static IEnumerable<T> Page<T>(this IEnumerable<T> source ,int pageNumber, int pageSize)
    { 
        if (pageNumber < 1)
            throw new ArgumentOutOfRangeException(nameof(pageNumber));

        if (pageSize < 1)
            throw new ArgumentOutOfRangeException(nameof(pageSize));

        int startIndex = (pageNumber - 1) * pageSize;
        int currentIndex = 0;

        foreach (T item in source)
        {
            if (currentIndex >= startIndex &&
                currentIndex < startIndex + pageSize)
            {
                yield return item;
            }

            if (currentIndex >= startIndex + pageSize - 1)
                yield break;

            currentIndex++;
        }
    }

    // R2
    public static T? FindById<T>( this IEnumerable<T> source, int id) where T : IHasId
    {
        foreach (T item in source)
        {
            if (item.Id == id)
                return item;
        }

        return default;
    }

    // R3
    public static IReadOnlyDictionary<int, T> ToIdDictionary<T>( this IEnumerable<T> source) where T : IHasId
    {
        Dictionary<int, T> dictionary = new();

        foreach (T item in source)
        {
            dictionary.Add(item.Id, item);
        }

        return dictionary;
    }
}