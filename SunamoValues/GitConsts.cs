namespace SunamoValues;

/// <summary>
/// Git merge conflict marker constants.
/// </summary>
public class GitConsts
{
    /// <summary>
    /// Starting marker of a merge conflict (ours).
    /// </summary>
    public const string StartingHead = "<<<<<<<";

    /// <summary>
    /// Delimiter between conflicting changes.
    /// </summary>
    public const string Delimiter = "=======";

    /// <summary>
    /// Ending marker of a merge conflict (theirs).
    /// </summary>
    public const string End = ">>>>>>>";
}
