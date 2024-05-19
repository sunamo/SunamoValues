namespace
#if SunamoCompare
SunamoCompare
#elif SunamoFileSystem
SunamoFileSystem
#elif SunamoNumbers
SunamoNumbers
#elif SunamoShared
SunamoShared
#elif SunamoString
SunamoString
#elif SunamoStringShared
SunamoStringShared
#elif SunamoDevCode
SunamoDevCode
#else
SunamoValues
#endif
;

public class NumConsts
{
    #region For easy copy
    public const int mOne = -1;
    #endregion

    public const int defaultPortIfCannotBeParsed = 587;
    /// <summary>
    /// Min age is 18 due to GDPR - below 18 is needed parent agreement of child
    /// </summary>
    public const int MinAge = 18;
    public static short nDtMinVal = 10101;
    public static short nDtMaxVal = 32271;
    /// <summary>
    /// one thousand
    /// </summary>
    public static int to = 1000;
    public const long kB = 1024;
    public const double zeroDouble = 0;

    public const float zeroFloat = 0;
    /// <summary>
    /// at int should be no postfix
    /// </summary>
    public const int one = 1;
    public const int zeroInt = 0;
}
