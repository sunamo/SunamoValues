namespace SunamoValues;

public class CA
{
    public static List<string> ToListString(params string[] s)
    {
        return s.ToList();
    }

    public static List<object> ToListObject(params Object[] lb)
    {
        return lb.ToList();
    }
}
