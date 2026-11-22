namespace SunamoValues.Constants;

/// <summary>
/// Represents the DT constants type.
/// </summary>
public class DTConstants
{
    /// <summary>
    /// The seconds in minute constant.
    /// </summary>
    public const long SecondsInMinute = 60;
    /// <summary>
    /// The seconds in hour constant.
    /// </summary>
    public const long SecondsInHour = SecondsInMinute * 60;
    /// <summary>
    /// The seconds in day constant.
    /// </summary>
    public const long SecondsInDay = SecondsInHour * 24;

    /// <summary>
    /// The days in week EN shortcut.
    /// </summary>
    public static readonly List<string> DaysInWeekENShortcut = new List<string>(["Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"]);
    /// <summary>
    /// The days in week EN.
    /// </summary>
    public static readonly List<string> DaysInWeekEN = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
    /// <summary>
    /// The months in year EN.
    /// </summary>
    public static readonly List<string> MonthsInYearEN = new List<string> { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

    /// <summary>
    /// The year start unix date constant.
    /// </summary>
    public const int YearStartUnixDate = 1970;
    /// <summary>
    /// The unix fs start.
    /// </summary>
    public static readonly DateTime UnixFsStart = new DateTime(YearStartUnixDate, 1, 1);
    /// <summary>
    /// The days in week CS.
    /// </summary>
    public static readonly List<string> DaysInWeekCS = new List<string> { MondayCs, TuesdayCs, WednesdayCs, ThursdayCs, FridayCs, SaturdayCs, SundayCs };
    /// <summary>
    /// The unix time start epoch.
    /// </summary>
    public static DateTime UnixTimeStartEpoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
    /// <summary>
    /// The win time start epoch.
    /// </summary>
    public static DateTime WinTimeStartEpoch = new DateTime(1601, 1, 1, 1, 0, 0, 0, DateTimeKind.Utc);

    #region Days of week CS
    /// <summary>
    /// The monday cs constant.
    /// </summary>
    public const string MondayCs = "Pondělí";
    /// <summary>
    /// The tuesday cs constant.
    /// </summary>
    public const string TuesdayCs = "Úterý";
    /// <summary>
    /// The wednesday cs constant.
    /// </summary>
    public const string WednesdayCs = "Středa";
    /// <summary>
    /// The thursday cs constant.
    /// </summary>
    public const string ThursdayCs = "Čtvrtek";
    /// <summary>
    /// The friday cs constant.
    /// </summary>
    public const string FridayCs = "Pátek";
    /// <summary>
    /// The saturday cs constant.
    /// </summary>
    public const string SaturdayCs = "Sobota";
    /// <summary>
    /// The sunday cs constant.
    /// </summary>
    public const string SundayCs = "Neděle";
    #endregion

    #region Months of year CS
    /// <summary>
    /// The january cs constant.
    /// </summary>
    public const string JanuaryCs = "Leden";
    /// <summary>
    /// The february cs constant.
    /// </summary>
    public const string FebruaryCs = "Únor";
    /// <summary>
    /// The march cs constant.
    /// </summary>
    public const string MarchCs = "Březen";
    /// <summary>
    /// The april cs constant.
    /// </summary>
    public const string AprilCs = "Duben";
    /// <summary>
    /// The may cs constant.
    /// </summary>
    public const string MayCs = "Květen";
    /// <summary>
    /// The june cs constant.
    /// </summary>
    public const string JuneCs = "Červen";
    /// <summary>
    /// The july cs constant.
    /// </summary>
    public const string JulyCs = "Červenec";
    /// <summary>
    /// The august cs constant.
    /// </summary>
    public const string AugustCs = "Srpen";
    /// <summary>
    /// The september cs constant.
    /// </summary>
    public const string SeptemberCs = "Září";
    /// <summary>
    /// The october cs constant.
    /// </summary>
    public const string OctoberCs = "Říjen";
    /// <summary>
    /// The november cs constant.
    /// </summary>
    public const string NovemberCs = "Listopad";
    /// <summary>
    /// The december cs constant.
    /// </summary>
    public const string DecemberCs = "Prosinec";
    #endregion

    /// <summary>
    /// The months in year CZ.
    /// </summary>
    public static readonly List<string> MonthsInYearCZ = new List<string> { JanuaryCs, FebruaryCs, MarchCs, AprilCs, MayCs, JuneCs, JulyCs, AugustCs, SeptemberCs, OctoberCs, NovemberCs, DecemberCs };
}
