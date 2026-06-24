namespace SunamoValues.All;

// Must be in shared due to HtmlTextWriterTag in System.Web.
// All values are lowercase.
public class AllHtmlTags
{
    // Sorted from longest to shortest due to comparing and finding right string.
    public static List<string>? All = null;

    static List<string>? withLeftArrow;

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
