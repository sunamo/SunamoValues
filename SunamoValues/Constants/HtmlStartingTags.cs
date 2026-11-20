namespace SunamoValues.Constants;

/// <summary>
/// Represents the html starting tags type.
/// </summary>
public class HtmlStartingTags
{
    /// <summary>
    /// The b constant.
    /// </summary>
    public const string B = "<b>";

    /// <summary>
    /// The i constant.
    /// </summary>
    public const string I = "<i>";

    /// <summary>
    /// The s constant.
    /// </summary>
    public const string S = "<s>";

    /// <summary>
    /// Get.
    /// </summary>
    /// <param name="tagName">The tag name.</param>
    /// <returns>The get result.</returns>
    public static string Get(string tagName) => "<" + tagName + ">";
}
