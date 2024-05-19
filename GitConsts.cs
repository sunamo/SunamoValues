namespace
#if SunamoFubuCsProjFile
SunamoFubuCsProjFile
#elif SunamoDevCode
SunamoDevCode
#else
SunamoValues
#endif
;
public class GitConsts
{
    public const string startingHead = "<<<<<<<";
    public const string delimiter = "=======";
    public const string end = ">>>>>>>";
}