namespace SunamoValues.Paths;
//public class CompareFilesPaths
//{
//    public static string GetFile(CompareExt c, int i)
//    {

//        return BasePathsHelper.vs + @"_tests\CompareTwoFiles\CompareTwoFiles\" + c + @"\"" + i + "." + c;
//    }
//}

//public class CompareTwoFilesHelper
//{
//    static string basePath = BasePathsHelper.bp + @"Projects\_tests\CompareTwoFiles\CompareTwoFiles\";

//    public static string Txt(int n)
//    {
//        return basePath + @"txt\" + n + ".txt";
//    }

//    public static string Html(int n)
//    {
//        return basePath + @"html\" + n + ".txt";
//    }
//}

public enum CompareExt
{
    cpp,
    aspx,
    cs,
    docs,
    html,
    js,
    json,
    txt
}
