namespace SunamoValues._sunamo.SunamoCollectionsGeneric;

/// <summary>
/// Collection helper constants. Must be here because SunamoValues cannot inherit from SunamoCollectionGeneric - it would cause a cycle.
/// </summary>
internal class CAGConsts
{
    /// <summary>
    /// Converts a params array to a list.
    /// </summary>
    /// <typeparam name="T">The type of elements.</typeparam>
    /// <param name="values">The values to convert to a list.</param>
    /// <returns>A list containing the provided values.</returns>
    internal static List<T> ToList<T>(params T[] values)
    {
        return values.ToList();
    }
}
