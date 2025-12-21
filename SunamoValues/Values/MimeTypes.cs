namespace SunamoValues.Values;

// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
// Must be in NS due to another MimeTypes is in TurnerSoftware.SitemapTools.web
public static partial class MimeTypes
{
    // code take here : https://github.com/samuelneff/MimeTypeMap/blob/master/src/MimeTypes/MimeTypeMap.cs
    // On MIT License
    static Dictionary<string, string> Mappings = null;
    public static string ForExtension(string ext)
    {
        if (Mappings == null)
        {
            Init();
        }

        return Mappings[ext];
    }
}