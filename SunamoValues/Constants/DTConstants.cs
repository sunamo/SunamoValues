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
    public static readonly List<string> DaysInWeekCS = new List<string> { Pondeli, Utery, Streda, Ctvrtek, Patek, Sobota, Nedele };
    public static DateTime UnixTimeStartEpoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
    public static DateTime WinTimeStartEpoch = new DateTime(1601, 1, 1, 1, 0, 0, 0, DateTimeKind.Utc);

    #region Days of week CS
    public const string Pondeli = "Pondělí";
    public const string Utery = "Úterý";
    public const string Streda = "Středa";
    public const string Ctvrtek = "Čtvrtek";
    public const string Patek = "Pátek";
    public const string Sobota = "Sobota";
    public const string Nedele = "Neděle";
    #endregion

    #region Months of year CS
    public const string Leden = "Leden";
    public const string Unor = "Únor";
    public const string Brezen = "Březen";
    public const string Duben = "Duben";
    public const string Kveten = "Květen";
    public const string Cerven = "Červen";
    public const string Cervenec = "Červenec";
    public const string Srpen = "Srpen";
    public const string Zari = "Září";
    public const string Rijen = "Říjen";
    public const string Listopad = "Listopad";
    public const string Prosinec = "Prosinec";
    #endregion

    public static readonly List<string> MonthsInYearCZ = new List<string> { Leden, Unor, Brezen, Duben, Kveten, Cerven, Cervenec, Srpen, Zari, Rijen, Listopad, Prosinec };
}
