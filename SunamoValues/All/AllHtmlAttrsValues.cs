// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy

namespace SunamoValues.All;

public class AllHtmlAttrsValues
{
    static bool initialized = false;
    public static List<string> list = new List<string>();
    public static void Init()
    {
        if (!initialized)
        {
            initialized = true;
            var data = typeof(HtmlAttrValue).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
            .Where(fi => fi.IsLiteral && !fi.IsInitOnly);
            foreach (var item in data)
            {
                list.Add(item.GetValue(null).ToString());
            }
            //list.Sort(new SunamoComparerICompare.StringLength.Desc(SunamoComparer.StringLength.Instance));
        }
    }
}
