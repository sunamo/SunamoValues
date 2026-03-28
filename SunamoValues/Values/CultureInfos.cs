namespace SunamoValues.Values;

/// <summary>
/// Culture information instances for localization.
/// </summary>
public class CultureInfos
{
    /// <summary>
    /// Czech culture info instance.
    /// </summary>
    public static CultureInfo? Cz = null;

    /// <summary>
    /// Neutral format provider.
    /// </summary>
    public static IFormatProvider? Neutral { get; set; }

    /// <summary>
    /// Initializes the Czech culture info.
    /// </summary>
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
