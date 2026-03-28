namespace SunamoValues.Values;

/// <summary>
/// MIME type mappings between file extensions and content types.
/// Must be in NS due to another MimeTypes is in TurnerSoftware.SitemapTools.web.
/// </summary>
public static partial class MimeTypes
{
    static Dictionary<string, string>? mappings = null;

    /// <summary>
    /// Returns the MIME type for the specified file extension.
    /// </summary>
    /// <param name="extension">The file extension (including the dot).</param>
    /// <returns>The corresponding MIME type string.</returns>
    public static string ForExtension(string extension)
    {
        if (mappings == null)
        {
            Init();
        }

        return mappings![extension];
    }
}
