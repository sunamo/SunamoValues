namespace SunamoValues.All;

/// <summary>
/// Must be in shared due to HtmlTextWriterTag in System.Web.
/// All values are lowercase.
/// </summary>
public class AllHtmlTags
{
    /// <summary>
    /// Sorted from longest to shortest due to comparing and finding right string.
    /// </summary>
    public static List<string>? All = null;

    static List<string>? withLeftArrow;

    /// <summary>
    /// Gets list of tags prefixed with left angle bracket and trailing space.
    /// </summary>
    public static List<string> WithLeftArrow
    {
        get
        {
            if (withLeftArrow == null)
            {
                Initialize();
                withLeftArrow = new List<string>(All!.Count);
                for (int i = 0; i < All.Count; i++)
                {
                    withLeftArrow.Add("<" + All[i] + " ");
                }
            }
            return withLeftArrow;
        }
    }

    /// <summary>
    /// Initializes the list of HTML tags from the HtmlTextWriterTag enum.
    /// </summary>
    public static void Initialize()
    {
        if (All == null)
        {
            All = new List<string>();
            foreach (var item in Enum.GetNames(typeof(HtmlTextWriterTag)))
            {
                All.Add(item.ToLower());
            }
        }
    }
}
