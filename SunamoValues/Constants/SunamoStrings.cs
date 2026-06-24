namespace SunamoValues.Constants;

// Only constants and simple methods allowed here.
public class SunamoStrings
{
    static SunamoStrings()
    {
        DefaultMessageIfEmpty = CreateMessageIfEmpty("data");
    }

    public static string? DefaultMessageIfEmpty = null;

    public static string CreateMessageIfEmpty(string text) => text + " is empty!";
}
