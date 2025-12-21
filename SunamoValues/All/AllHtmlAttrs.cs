namespace SunamoValues.All;

// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
public class AllHtmlAttrs
{
    //
    public static List<string> list = null;
    public static void Initialize()
    {
        if (list == null)
        {
            list = new List<string>();
            foreach (var item in Enum.GetNames(typeof(HtmlTextWriterAttribute)))
            {
                list.Add(item.ToLower());
            }
            //list.Sort(new SunamoComparerICompare.StringLength.Desc(SunamoComparer.StringLength.Instance));
        }
    }
}