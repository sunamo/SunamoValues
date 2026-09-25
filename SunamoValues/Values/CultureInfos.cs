namespace SunamoValues.Values;

public class CultureInfos
{
    public static CultureInfo? Cz = null;

    public static IFormatProvider? Neutral { get; set; }

    public static void Init()
    {
        if (Cz == null)
        {
            Cz = CultureInfo.GetCultureInfo("cs");
            if (Cz == null)
            {
                System.Diagnostics.Debugger.Break();
            }
        }
    }
}
