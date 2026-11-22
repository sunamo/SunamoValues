namespace SunamoValues.Values;

/// <summary>
/// Represents the all lists type.
/// </summary>
public partial class AllLists
{
    // In key is long name, in value letter.
    /// <summary>
    /// The html entities dict.
    /// </summary>
    public static Dictionary<string, string>? HtmlEntitiesDict = null;

    // When entity has more names, there is just one.
    // In key is letter, in value long name.
    /// <summary>
    /// The html entities full names.
    /// </summary>
    public static Dictionary<string, string>? HtmlEntitiesFullNames = null;
}
