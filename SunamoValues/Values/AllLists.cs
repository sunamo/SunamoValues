namespace SunamoValues.Values;

/// <summary>
/// Shared lists of commonly used values (HTML entities, brackets, etc.).
/// </summary>
public partial class AllLists
{
    /// <summary>
    /// In key is long name, in value letter.
    /// </summary>
    public static Dictionary<string, string>? HtmlEntitiesDict = null;

    /// <summary>
    /// When entity has more names, there is just one.
    /// In key is letter, in value long name.
    /// </summary>
    public static Dictionary<string, string>? HtmlEntitiesFullNames = null;
}
