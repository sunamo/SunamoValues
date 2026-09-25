namespace SunamoValues.All;

public class AllHtmlAttrs
{
    public static List<string>? All = null;

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
