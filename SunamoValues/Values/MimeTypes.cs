namespace SunamoValues.Values;

// Must be in NS due to another MimeTypes is in TurnerSoftware.SitemapTools.web.
public static partial class MimeTypes
{
    static Dictionary<string, string>? mappings = null;

    /// <summary>
    /// For extension.
    /// </summary>
    /// <param name="extension">The extension.</param>
    /// <returns>The for extension result.</returns>
    public static string ForExtension(string extension)
    {
        if (mappings == null)
        {
            Init();
        }

        return mappings![extension];
    }
}
