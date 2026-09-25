namespace SunamoValues.Constants;

public class HtmlEndingTags
{
    public const string B = "</b>";

    public const string I = "</i>";

    public const string S = "</s>";

    public static string Get(string tagName) => "</" + tagName + ">";
}
