namespace
#if SunamoCl
SunamoCl
#elif SunamoCollections
SunamoCollections
#elif SunamoFileSystem
SunamoFileSystem
#elif SunamoFtp
SunamoFtp
#elif SunamoLogger
SunamoLogger
#elif SunamoUri
SunamoUri
#else
SunamoValues
#endif
;
public class EmptyArrays
{
    public static Char[] Chars = new Char[] { };
    public static string[] Strings = new string[] { };
    public static Object[] Objects = new Object[] { };
    public static Byte[] Bytes = new Byte[] { };
}