namespace SunamoValues.All;

/// <summary>
/// Contains all HTML attribute names derived from HtmlTextWriterAttribute enum.
/// </summary>
public class AllHtmlAttrs
{
    /// <summary>
    /// List of all HTML attribute names in lowercase.
    /// </summary>
    public static List<string>? All = null;

    /// <summary>
    /// Initializes the list of HTML attributes from the HtmlTextWriterAttribute enum.
    /// </summary>
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
