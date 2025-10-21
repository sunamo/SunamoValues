// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoValues.Constants;
/// <summary>
/// Here can be just constants, not methods
/// </summary>
public class SunamoStrings
{
    // TODO: Clean which are not necessary here
    static SunamoStrings()
    {
        messageIfEmpty = MessageIfEmpty("data");
    }
    /// <summary>
    /// Wasn't found any data to show
    /// </summary>
    public static string messageIfEmpty = null;
    //public static string IsNotInRange = "is not in range";
    public static string MessageIfEmpty(string p)
    {
        return p + " is empty!";
    }
}
