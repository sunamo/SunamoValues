namespace SunamoValues.All;

// Must be in shared due to HtmlTextWriterTag in System.Web.
// All values are lowercase.
/// <summary>
/// Represents the all html tags type.
/// </summary>
public class AllHtmlTags
{
    // Sorted from longest to shortest due to comparing and finding right string.
    /// <summary>
    /// The all.
    /// </summary>
    public static List<string>? All = null;

    static List<string>? withLeftArrow;

    /// <summary>
    /// The with left arrow.
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
    /// Initialize.
    /// </summary>
    /// <returns>The initialize result.</returns>
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
