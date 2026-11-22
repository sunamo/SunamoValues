namespace SunamoValues;

/// <summary>
/// Single character constants; the names match the one-character constants of <see cref="AllStrings"/>.
/// </summary>
public static class AllChars
{
    /// <summary>The dot character.</summary>
    public const char dot = '.';
    /// <summary>The period character (same as dot).</summary>
    public const char period = '.';
    /// <summary>The comma character.</summary>
    public const char comma = ',';
    /// <summary>The dash character.</summary>
    public const char dash = '-';
    /// <summary>The question mark character.</summary>
    public const char q = '?';
    /// <summary>The question mark character (same as q).</summary>
    public const char quest = '?';
    /// <summary>The apostrophe character.</summary>
    public const char apostrophe = '\'';
    /// <summary>The apostrophe character (same as apostrophe).</summary>
    public const char apos = '\'';
    /// <summary>The underscore character.</summary>
    public const char us = '_';
    /// <summary>The underscore character (same as us).</summary>
    public const char lowbar = '_';
    /// <summary>The space character.</summary>
    public const char space = ' ';
    /// <summary>The left bracket character.</summary>
    public const char lb = '(';
    /// <summary>The left bracket character (same as lb).</summary>
    public const char lpar = '(';
    /// <summary>The right bracket character.</summary>
    public const char rb = ')';
    /// <summary>The right bracket character (same as rb).</summary>
    public const char rpar = ')';
    /// <summary>The tab character.</summary>
    public const char tab = '\t';
    /// <summary>The line feed character.</summary>
    public const char nl = '\n';
    /// <summary>The carriage return character.</summary>
    public const char cr = '\r';
    /// <summary>The slash character.</summary>
    public const char slash = '/';
    /// <summary>The slash character (same as slash).</summary>
    public const char sol = '/';
    /// <summary>The backslash character.</summary>
    public const char bs = '\\';
    /// <summary>The asterisk character.</summary>
    public const char asterisk = '*';
    /// <summary>The asterisk character (same as asterisk).</summary>
    public const char ast = '*';
    /// <summary>The semicolon character.</summary>
    public const char sc = ';';
    /// <summary>The semicolon character (same as sc).</summary>
    public const char semi = ';';
    /// <summary>The quotation mark character.</summary>
    public const char qm = '"';
    /// <summary>The colon character.</summary>
    public const char colon = ':';
    /// <summary>The exclamation mark character.</summary>
    public const char excl = '!';
    /// <summary>The less-than character.</summary>
    public const char lt = '<';
    /// <summary>The equals character.</summary>
    public const char equals = '=';
    /// <summary>The greater-than character.</summary>
    public const char gt = '>';
    /// <summary>The ampersand character.</summary>
    public const char amp = '&';
    /// <summary>The left curly bracket character.</summary>
    public const char lcub = '{';
    /// <summary>The right curly bracket character.</summary>
    public const char rcub = '}';
    /// <summary>The left square bracket character.</summary>
    public const char lsqb = '[';
    /// <summary>The right square bracket character.</summary>
    public const char rsqb = ']';
    /// <summary>The vertical bar character.</summary>
    public const char verbar = '|';
    /// <summary>The at sign character.</summary>
    public const char commat = '@';
    /// <summary>The plus character.</summary>
    public const char plus = '+';
    /// <summary>The number sign character.</summary>
    public const char num = '#';
    /// <summary>The percent character.</summary>
    public const char percnt = '%';
    /// <summary>The dollar character.</summary>
    public const char dollar = '$';
    /// <summary>The circumflex character.</summary>
    public const char Hat = '^';

    /// <summary>The lower case letters a to z.</summary>
    public static readonly IReadOnlyList<char> lowerChars = new[]
    {
        'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
        'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
    };

    /// <summary>The upper case letters A to Z.</summary>
    public static readonly IReadOnlyList<char> upperChars = new[]
    {
        'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
        'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
    };

    /// <summary>The digits 1 to 9 and 0.</summary>
    public static readonly IReadOnlyList<char> numericChars = new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

    /// <summary>The special characters commonly allowed in passwords.</summary>
    public static readonly IReadOnlyList<char> specialChars = new[] { '!', '@', '#', '$', '%', '^', '&', '*', '?', '_', '~' };

    /// <summary>The remaining special characters: quotes, dashes, brackets and punctuation.</summary>
    public static readonly IReadOnlyList<char> specialChars2 = new[]
    {
        '\u201C', '\u201D', '-', '\u2018', '\u2019',
        ',', '.', '\'', ')', '/', '<', '>', '{', '}', '[', '|', ';', '+', ']', '\u2013', '/'
    };

    /// <summary>All special characters: specialChars followed by specialChars2.</summary>
    public static readonly IReadOnlyList<char> specialCharsAll = specialChars.Concat(specialChars2).ToArray();
}
