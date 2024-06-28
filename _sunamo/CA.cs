namespace SunamoValues;

internal class CA
{
    internal static List<string> ToListString(params string[] s)
    {
        return s.ToList();
    }

    internal static List<object> ToListObject(params Object[] lb)
    {
        return lb.ToList();
    }
}
