// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoValues.Values;

public class ConstsAspx
{
    public static readonly string startAspxComment = "<%--";
    public static readonly string endAspxComment = "--%>";
    public static readonly string startHtmlComment = "<!--";
    public static readonly string endHtmlComment = "-->";
    public static readonly List<string> all = new List<string>([startAspxComment, endAspxComment, startHtmlComment, endHtmlComment, ">", "<"]);
}