namespace SunamoValues.All;

public class AllHtmlAttrsValues
{
    static bool initialized = false;

    public static List<string> All = new List<string>();

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
