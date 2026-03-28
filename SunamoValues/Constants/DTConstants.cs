namespace SunamoValues.Constants;

/// <summary>
/// Date and time related constants.
/// </summary>
public class DTConstants
{
    /// <summary>
    /// Number of seconds in one minute.
    /// </summary>
    public const long SecondsInMinute = 60;

    /// <summary>
    /// Number of seconds in one hour.
    /// </summary>
    public const long SecondsInHour = SecondsInMinute * 60;

    /// <summary>
    /// Number of seconds in one day.
    /// </summary>
    public const long SecondsInDay = SecondsInHour * 24;

    /// <summary>
    /// Abbreviated English day names (Mon, Tue, etc.).
    /// </summary>
    public static readonly List<string> DaysInWeekENShortcut = new List<string>(["Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"]);

    /// <summary>
    /// Full English day names.
    /// </summary>
    public static readonly List<string> DaysInWeekEN = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

    /// <summary>
    /// Full English month names.
    /// </summary>
    public static readonly List<string> MonthsInYearEN = new List<string> { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

    /// <summary>
    /// The year when Unix epoch starts.
    /// </summary>
    public const int YearStartUnixDate = 1970;

    /// <summary>
    /// Unix file system start date.
    /// </summary>
    public static readonly DateTime UnixFsStart = new DateTime(YearStartUnixDate, 1, 1);

    /// <summary>
    /// Czech day names.
    /// </summary>
    public static readonly List<string> DaysInWeekCS = new List<string> { Pondeli, Utery, Streda, Ctvrtek, Patek, Sobota, Nedele };

    /// <summary>
    /// Unix time start epoch (UTC).
    /// </summary>
    public static DateTime UnixTimeStartEpoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

    /// <summary>
    /// Windows time start epoch (UTC).
    /// </summary>
    public static DateTime WinTimeStartEpoch = new DateTime(1601, 1, 1, 1, 0, 0, 0, DateTimeKind.Utc);

    #region Days of week CS
    /// <summary>
    /// Monday in Czech.
    /// </summary>
    public const string Pondeli = "Pond\u011Bl\u00ED";

    /// <summary>
    /// Tuesday in Czech.
    /// </summary>
    public const string Utery = "\u00DAter\u00FD";

    /// <summary>
    /// Wednesday in Czech.
    /// </summary>
    public const string Streda = "St\u0159eda";

    /// <summary>
    /// Thursday in Czech.
    /// </summary>
    public const string Ctvrtek = "\u010Ctvrtek";

    /// <summary>
    /// Friday in Czech.
    /// </summary>
    public const string Patek = "P\u00E1tek";

    /// <summary>
    /// Saturday in Czech.
    /// </summary>
    public const string Sobota = "Sobota";

    /// <summary>
    /// Sunday in Czech.
    /// </summary>
    public const string Nedele = "Ned\u011Ble";
    #endregion

    #region Months of year CS
    /// <summary>
    /// January in Czech.
    /// </summary>
    public const string Leden = "Leden";

    /// <summary>
    /// February in Czech.
    /// </summary>
    public const string Unor = "\u00DAnor";

    /// <summary>
    /// March in Czech.
    /// </summary>
    public const string Brezen = "B\u0159ezen";

    /// <summary>
    /// April in Czech.
    /// </summary>
    public const string Duben = "Duben";

    /// <summary>
    /// May in Czech.
    /// </summary>
    public const string Kveten = "Kv\u011Bten";

    /// <summary>
    /// June in Czech.
    /// </summary>
    public const string Cerven = "\u010Cerven";

    /// <summary>
    /// July in Czech.
    /// </summary>
    public const string Cervenec = "\u010Cervenec";

    /// <summary>
    /// August in Czech.
    /// </summary>
    public const string Srpen = "Srpen";

    /// <summary>
    /// September in Czech.
    /// </summary>
    public const string Zari = "Z\u00E1\u0159\u00ED";

    /// <summary>
    /// October in Czech.
    /// </summary>
    public const string Rijen = "\u0158\u00EDjen";

    /// <summary>
    /// November in Czech.
    /// </summary>
    public const string Listopad = "Listopad";

    /// <summary>
    /// December in Czech.
    /// </summary>
    public const string Prosinec = "Prosinec";
    #endregion

    /// <summary>
    /// Czech month names.
    /// </summary>
    public static readonly List<string> MonthsInYearCZ = new List<string> { Leden, Unor, Brezen, Duben, Kveten, Cerven, Cervenec, Srpen, Zari, Rijen, Listopad, Prosinec };
}
