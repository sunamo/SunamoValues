// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoValues._sunamo.SunamoCollectionsGeneric;

internal class CAGConsts
{

    /// <summary>
    /// Tady to musí být, SunamoValues nemůže dědit od SunamoCollectionGeneric - vzniklo by Cycle detected
    /// Těch pár řádků mě snad nezabije.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="t"></param>
    /// <returns></returns>
    internal static List<T> ToList<T>(params T[] t)
    {
        return t.ToList();
    }
}
