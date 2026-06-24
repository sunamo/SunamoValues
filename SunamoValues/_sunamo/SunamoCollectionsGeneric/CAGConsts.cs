namespace SunamoValues._sunamo.SunamoCollectionsGeneric;

// Must be here because SunamoValues cannot inherit from SunamoCollectionGeneric - it would cause a cycle.
internal class CAGConsts
{
    internal static List<T> ToList<T>(params T[] values)
    {
        return values.ToList();
    }
}
