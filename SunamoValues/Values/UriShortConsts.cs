namespace SunamoValues.Values;

/// <summary>
/// Short URI constants for Sunamo web services.
/// </summary>
public class UriShortConsts
{
    /// <summary>
    /// Developer portal short URI.
    /// </summary>
    public const string DevCz = "dev.sunamo.net";

    /// <summary>
    /// Applications portal short URI.
    /// </summary>
    public const string AppCz = "app.sunamo.net";

    /// <summary>
    /// Geocaching service short URI.
    /// </summary>
    public const string GeoCz = "geo.sunamo.net";

    /// <summary>
    /// Dart service short URI.
    /// </summary>
    public const string ErtCz = "var.sunamo.net";

    /// <summary>
    /// URL shortener service short URI.
    /// </summary>
    public const string ShoCz = "sho.sunamo.net";

    /// <summary>
    /// Repair service short URI.
    /// </summary>
    public const string RpsCz = "rps.sunamo.net";

    /// <summary>
    /// Photos service short URI.
    /// </summary>
    public const string PhsCz = "phs.sunamo.net";

    /// <summary>
    /// HTTP service short URI.
    /// </summary>
    public const string HtpCz = "htp.sunamo.net";

    /// <summary>
    /// Lyrics service short URI.
    /// </summary>
    public const string LyrCz = "lyr.sunamo.net";

    /// <summary>
    /// Collection of all short URI constants.
    /// </summary>
    public static List<string> All = CAGConsts.ToList(DevCz, LyrCz, AppCz, GeoCz, ErtCz, RpsCz, ShoCz, PhsCz);
}
