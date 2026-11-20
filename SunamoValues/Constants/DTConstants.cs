namespace SunamoValues.Constants;

public class DTConstants
{
    public const long SecondsInMinute = 60;
    public const long SecondsInHour = SecondsInMinute * 60;
    public const long SecondsInDay = SecondsInHour * 24;

    public static readonly List<string> DaysInWeekENShortcut = new List<string>(["Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"]);
    public static readonly List<string> DaysInWeekEN = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
    public static readonly List<string> MonthsInYearEN = new List<string> { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

    public const int YearStartUnixDate = 1970;
    public static readonly DateTime UnixFsStart = new DateTime(YearStartUnixDate, 1, 1);
    public static readonly List<string> DaysInWeekCS = new List<string> { MondayCs, TuesdayCs, WednesdayCs, ThursdayCs, FridayCs, SaturdayCs, SundayCs };
    public static DateTime UnixTimeStartEpoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
    public static DateTime WinTimeStartEpoch = new DateTime(1601, 1, 1, 1, 0, 0, 0, DateTimeKind.Utc);

    #region Days of week CS
    public const string MondayCs = "Pondělí";
    public const string TuesdayCs = "Úterý";
    public const string WednesdayCs = "Středa";
    public const string ThursdayCs = "Čtvrtek";
    public const string FridayCs = "Pátek";
    public const string SaturdayCs = "Sobota";
    public const string SundayCs = "Neděle";
    #endregion

    #region Months of year CS
    public const string JanuaryCs = "Leden";
    public const string FebruaryCs = "Únor";
    public const string MarchCs = "Březen";
    public const string AprilCs = "Duben";
    public const string MayCs = "Květen";
    public const string JuneCs = "Červen";
    public const string JulyCs = "Červenec";
    public const string AugustCs = "Srpen";
    public const string SeptemberCs = "Září";
    public const string OctoberCs = "Říjen";
    public const string NovemberCs = "Listopad";
    public const string DecemberCs = "Prosinec";
    #endregion

    public static readonly List<string> MonthsInYearCZ = new List<string> { JanuaryCs, FebruaryCs, MarchCs, AprilCs, MayCs, JuneCs, JulyCs, AugustCs, SeptemberCs, OctoberCs, NovemberCs, DecemberCs };
}
