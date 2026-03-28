namespace SunamoValues.All;

/// <summary>
/// Contains all HTML attribute values derived from HtmlAttrValue constants.
/// </summary>
public class AllHtmlAttrsValues
{
    static bool initialized = false;

    /// <summary>
    /// List of all HTML attribute values.
    /// </summary>
    public static List<string> All = new List<string>();

    /// <summary>
    /// Initializes the list of HTML attribute values from HtmlAttrValue class constants.
    /// </summary>
    public static void Init()
    {
        if (!initialized)
        {
            initialized = true;
            var data = typeof(HtmlAttrValue).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
            .Where(fi => fi.IsLiteral && !fi.IsInitOnly);
            foreach (var item in data)
            {
                All.Add(item.GetValue(null)?.ToString() ?? string.Empty);
            }
        }
    }
}
