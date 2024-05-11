namespace
#if SunamoCl
SunamoCl
#elif SunamoLogger
SunamoLogger
#elif SunamoCollectionsGeneric
    SunamoCollectionsGeneric
#elif SunamoTextOutputGenerator
SunamoTextOutputGenerator
#else
SunamoValues
#endif
;

/// <summary>
///     Usage:
/// </summary>
public class Messages
{
    public const string RepairErrors = "Please correct the errors and try again";
    public const string AppWillBeTerminated = "Thank you for using my app. Press enter to app will be terminated.";
    public const string NoData = "When you will have the input data, run the program again.";
    public const string SomeErrorsOccured = "Some errors occured";
}
