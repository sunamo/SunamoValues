namespace SunamoValues.Values;

public partial class AllLists
{
    // In key is long name, in value letter.
    public static Dictionary<string, string>? HtmlEntitiesDict = null;

    // When entity has more names, there is just one.
    // In key is letter, in value long name.
    public static Dictionary<string, string>? HtmlEntitiesFullNames = null;
}
