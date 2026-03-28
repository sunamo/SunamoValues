namespace SunamoValues.Constants;

/// <summary>
/// Shared string constants and generators. Only constants and simple methods allowed here.
/// </summary>
public class SunamoStrings
{
    static SunamoStrings()
    {
        DefaultMessageIfEmpty = CreateMessageIfEmpty("data");
    }

    /// <summary>
    /// Default "data is empty" message.
    /// </summary>
    public static string? DefaultMessageIfEmpty = null;

    /// <summary>
    /// Creates an "is empty" message for the specified subject.
    /// </summary>
    /// <param name="text">The subject that is empty.</param>
    /// <returns>A formatted empty message string.</returns>
    public static string CreateMessageIfEmpty(string text)
    {
        return text + " is empty!";
    }
}
