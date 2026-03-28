namespace SunamoValues.Constants;

/// <summary>
/// HTML starting (opening) tag constants.
/// </summary>
public class HtmlStartingTags
{
    /// <summary>
    /// Opening bold tag.
    /// </summary>
    public const string B = "<b>";

    /// <summary>
    /// Opening italic tag.
    /// </summary>
    public const string I = "<i>";

    /// <summary>
    /// Opening strikethrough tag.
    /// </summary>
    public const string S = "<s>";

    /// <summary>
    /// Generates an opening tag for the specified tag name.
    /// </summary>
    /// <param name="tagName">The HTML tag name.</param>
    /// <returns>The opening tag string.</returns>
    public static string Get(string tagName)
    {
        return "<" + tagName + ">";
    }
}
