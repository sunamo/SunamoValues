namespace SunamoValues.Constants;

/// <summary>
/// HTML ending (closing) tag constants.
/// </summary>
public class HtmlEndingTags
{
    /// <summary>
    /// Closing bold tag.
    /// </summary>
    public const string B = "</b>";

    /// <summary>
    /// Closing italic tag.
    /// </summary>
    public const string I = "</i>";

    /// <summary>
    /// Closing strikethrough tag.
    /// </summary>
    public const string S = "</s>";

    /// <summary>
    /// Generates a closing tag for the specified tag name.
    /// </summary>
    /// <param name="tagName">The HTML tag name.</param>
    /// <returns>The closing tag string.</returns>
    public static string Get(string tagName)
    {
        return "</" + tagName + ">";
    }
}
