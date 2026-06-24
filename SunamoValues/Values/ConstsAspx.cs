namespace SunamoValues.Values;

public class ConstsAspx
{
    public static readonly string StartAspxComment = "<%--";

    public static readonly string EndAspxComment = "--%>";

    public static readonly string StartHtmlComment = "<!--";

    public static readonly string EndHtmlComment = "-->";

    public static readonly List<string> All = new List<string>([StartAspxComment, EndAspxComment, StartHtmlComment, EndHtmlComment, ">", "<"]);
}
