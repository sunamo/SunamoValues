namespace SunamoValues.All;

/// <summary>
/// Represents the all html attrs values type.
/// </summary>
public class AllHtmlAttrsValues
{
    static bool initialized = false;

    /// <summary>
    /// The all.
    /// </summary>
    public static List<string> All = new List<string>();

    /// <summary>
    /// Init.
    /// </summary>
    /// <typeparam name="string">The type string.</typeparam>
    /// <returns>The init result.</returns>
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
