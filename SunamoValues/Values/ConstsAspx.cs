namespace SunamoValues.Values;

/// <summary>
/// ASP.NET and HTML comment marker constants.
/// </summary>
public class ConstsAspx
{
    /// <summary>
    /// ASPX comment start marker.
    /// </summary>
    public static readonly string StartAspxComment = "<%--";

    /// <summary>
    /// ASPX comment end marker.
    /// </summary>
    public static readonly string EndAspxComment = "--%>";

    /// <summary>
    /// HTML comment start marker.
    /// </summary>
    public static readonly string StartHtmlComment = "<!--";

    /// <summary>
    /// HTML comment end marker.
    /// </summary>
    public static readonly string EndHtmlComment = "-->";

    /// <summary>
    /// All comment markers and angle brackets.
    /// </summary>
    public static readonly List<string> All = new List<string>([StartAspxComment, EndAspxComment, StartHtmlComment, EndHtmlComment, ">", "<"]);
}
