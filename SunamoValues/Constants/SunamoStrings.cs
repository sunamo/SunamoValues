namespace SunamoValues.Constants;

// Only constants and simple methods allowed here.
/// <summary>
/// Represents the sunamo strings type.
/// </summary>
public class SunamoStrings
{
    static SunamoStrings()
    {
        DefaultMessageIfEmpty = CreateMessageIfEmpty("data");
    }

    /// <summary>
    /// The default message if empty.
    /// </summary>
    public static string? DefaultMessageIfEmpty = null;

    /// <summary>
    /// Create message if empty.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns>The create message if empty result.</returns>
    public static string CreateMessageIfEmpty(string text) => text + " is empty!";
}
