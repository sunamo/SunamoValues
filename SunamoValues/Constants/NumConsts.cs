namespace SunamoValues.Constants;

/// <summary>
/// Numeric constants.
/// </summary>
public class NumConsts
{
    #region For easy copy
    /// <summary>
    /// Constant value of minus one.
    /// </summary>
    public const int MOne = -1;
    #endregion

    /// <summary>
    /// Default port number used when port cannot be parsed.
    /// </summary>
    public const int DefaultPortIfCannotBeParsed = 587;

    /// <summary>
    /// Min age is 18 due to GDPR - below 18 is needed parent agreement of child.
    /// </summary>
    public const int MinAge = 18;

    /// <summary>
    /// Numeric DateTime min value as short.
    /// </summary>
    public static short NDtMinVal = 10101;

    /// <summary>
    /// Numeric DateTime max value as short.
    /// </summary>
    public static short NDtMaxVal = 32271;

    /// <summary>
    /// One thousand.
    /// </summary>
    public static int OneThousand = 1000;

    /// <summary>
    /// One kilobyte in bytes.
    /// </summary>
    public const long KB = 1024;

    /// <summary>
    /// Zero as double.
    /// </summary>
    public const double ZeroDouble = 0;

    /// <summary>
    /// Zero as float.
    /// </summary>
    public const float ZeroFloat = 0;

    /// <summary>
    /// One as integer (no type postfix).
    /// </summary>
    public const int One = 1;

    /// <summary>
    /// Zero as integer.
    /// </summary>
    public const int ZeroInt = 0;
}
