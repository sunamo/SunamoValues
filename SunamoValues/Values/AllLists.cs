// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoValues.Values;
public partial class AllLists
{
    /// <summary>
    /// In key is long name, in value letter
    /// </summary>
    public static Dictionary<string, string> htmlEntitiesDict = null;
    /// <summary>
    /// When entity have more names, there is just one
    /// In key is letter, in value long name
    /// </summary>
    public static Dictionary<string, string> htmlEntitiesFullNames = null;
}