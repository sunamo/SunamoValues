namespace SunamoValues.All;

/// <summary>
/// Represents the all html attrs type.
/// </summary>
public class AllHtmlAttrs
{
    /// <summary>
    /// The all.
    /// </summary>
    public static List<string>? All = null;

    /// <summary>
    /// Initialize.
    /// </summary>
    /// <returns>The initialize result.</returns>
    public static void Initialize()
    {
        if (All == null)
        {
            All = new List<string>();
            foreach (var item in Enum.GetNames(typeof(HtmlTextWriterAttribute)))
            {
                All.Add(item.ToLower());
            }
        }
    }
}
