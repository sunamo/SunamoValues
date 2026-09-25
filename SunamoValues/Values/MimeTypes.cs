namespace SunamoValues.Values;

// Must be in NS due to another MimeTypes is in TurnerSoftware.SitemapTools.web.
public static partial class MimeTypes
{
    static Dictionary<string, string>? mappings = null;

    public static string ForExtension(string extension)
    {
        if (mappings == null)
        {
            Init();
        }

        return mappings![extension];
    }
}
