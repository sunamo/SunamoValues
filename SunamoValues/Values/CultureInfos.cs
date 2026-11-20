namespace SunamoValues.Values;

/// <summary>
/// Represents the culture infos type.
/// </summary>
public class CultureInfos
{
    /// <summary>
    /// The cz.
    /// </summary>
    public static CultureInfo? Cz = null;

    /// <summary>
    /// Gets or sets the neutral.
    /// </summary>
    public static IFormatProvider? Neutral { get; set; }

    /// <summary>
    /// Init.
    /// </summary>
    /// <returns>The init result.</returns>
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
