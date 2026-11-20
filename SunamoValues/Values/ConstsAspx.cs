namespace SunamoValues.Values;

/// <summary>
/// Represents the consts aspx type.
/// </summary>
public class ConstsAspx
{
    /// <summary>
    /// The start aspx comment.
    /// </summary>
    public static readonly string StartAspxComment = "<%--";

    /// <summary>
    /// The end aspx comment.
    /// </summary>
    public static readonly string EndAspxComment = "--%>";

    /// <summary>
    /// The start html comment.
    /// </summary>
    public static readonly string StartHtmlComment = "<!--";

    /// <summary>
    /// The end html comment.
    /// </summary>
    public static readonly string EndHtmlComment = "-->";

    /// <summary>
    /// The all.
    /// </summary>
    public static readonly List<string> All = new List<string>([StartAspxComment, EndAspxComment, StartHtmlComment, EndHtmlComment, ">", "<"]);
}
