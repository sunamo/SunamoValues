namespace SunamoValues.Values;

// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
public class CultureInfos
{
    public static CultureInfo cz = null;
    public static IFormatProvider neutral { get; set; }
    public static void Init()
    {
        if (cz == null)
        {
            cz = CultureInfo.GetCultureInfo("cs");
            if (cz == null)
            {
                System.Diagnostics.Debugger.Break();
                // use cs-CZ
            }
        }
    }
}