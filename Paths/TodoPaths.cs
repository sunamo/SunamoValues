namespace SunamoValues;
public class TodoPaths
{
    #region Todo
    public const string OneDrive = @"D:\OneDrive\Drive\Todo\";
    public const string OneDriveText = @"D:\OneDrive\Text\Todo\";
    public const string GoogleDriveArchive = @"D:\Sync\_Archive\Todo\";
    public const string GoogleDrive = @"D:\Sync\Todo\";
    #endregion

    public static bool ExistsFolder(string oneDrive, string name)
    {
        var folders = Directory.GetDirectories(oneDrive, name + "*");
        return folders.Length > 0;
    }

    public static string FileIn(string oneDrive, string name, string file)
    {
        var folders = Directory.GetDirectories(oneDrive, name + " " + "*");
        if (folders.Length > 0)
        {
            return Path.Combine(folders.First(), file);
        }
        return string.Empty;
    }
}
