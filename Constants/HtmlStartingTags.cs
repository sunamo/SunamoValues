
namespace SunamoValues;
public class HtmlStartingTags
{
    static Type type = typeof(HtmlStartingTags);
    public const string b = "<b>";
    public const string i = "<i>";
    public const string s = "<s>";

    internal static string Get(string value)
    {
        return "<" + value + ">";
    }
    //public static string Get(string value)
    //{
    //    var v = RH.GetValuesOfConsts(type, value);
    //    return v.First().Value;
    //}
}
