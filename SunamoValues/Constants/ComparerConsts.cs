namespace SunamoValues.Constants;

/// <summary>
/// Constants used in IComparer implementations.
/// </summary>
public class ComparerConsts
{
    /// <summary>
    /// X comes before Y (descending).
    /// </summary>
    public const int XDesc = -1;

    /// <summary>
    /// Y comes after X (descending).
    /// </summary>
    public const int YDesc = 1;

    /// <summary>
    /// Both values are equal.
    /// </summary>
    public const int Equal = 0;

    /// <summary>
    /// X comes before Y (ascending).
    /// </summary>
    public const int XAsc = -1;

    /// <summary>
    /// Y comes after X (ascending).
    /// </summary>
    public const int YAsc = 1;

    /// <summary>
    /// Higher comparison result.
    /// </summary>
    public const int Higher = 1;

    /// <summary>
    /// Lower comparison result.
    /// </summary>
    public const int Lower = -1;
}
