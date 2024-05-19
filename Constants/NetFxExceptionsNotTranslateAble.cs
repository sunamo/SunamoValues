namespace
#if SunamoFileSystem
SunamoFileSystem
#elif SunamoGetFiles
SunamoGetFiles
#else
SunamoValues
#endif
;
public class NetFxExceptionsNotTranslateAble
{
    public const string TheNameOfTheFileCannotBeResolvedByTheSystem
    = "The name of the file cannot be resolved by the system";
}