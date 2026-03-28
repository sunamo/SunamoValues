namespace SunamoValues.Values;

/// <summary>
/// Emoticon pattern collections. All must be public due to object.GetFields().
/// </summary>
public class Emoticons
{
    /// <summary>
    /// Happy face emoticon patterns (:3 - 10:30).
    /// </summary>
    public string HappyFace { get; set; } = @":‑)
:)	:-]
:]	:-3
:->
:>	8-)
8)	:-}
:}	:o)	:c)	:^)
=]
=)
:‑D
:D	8‑D
8D	x‑D
xD	X‑D
XD
=D
=3	B^D";

    /// <summary>
    /// Frown, sad, angry, pouting emoticon patterns.
    /// </summary>
    public string FrownSadAngryPouting { get; set; } = @":‑(
:(	:‑c
:c	:‑<
:<	:‑[
:[	:-||
>:[
:{
:@
>:(";

    /// <summary>
    /// Crying emoticon patterns.
    /// </summary>
    public string Crying { get; set; } = @":'‑(
:'(";

    /// <summary>
    /// Tears of happiness emoticon patterns.
    /// </summary>
    public string TearsOfHappiness { get; set; } = @":'‑)
:')";

    /// <summary>
    /// Horror, disgust, sadness, greed, dismay emoticon patterns.
    /// </summary>
    public string HorrorDisgustSadnessGreadDismay { get; set; } = @":‑O
:O	:‑o
:o	:-0	8‑0
>:O";

    /// <summary>
    /// Kiss emoticon patterns.
    /// </summary>
    public string Kiss { get; set; } = @":-*
:*
:×";

    /// <summary>
    /// Wink or smirk emoticon patterns.
    /// </summary>
    public string WinkSmirk { get; set; } = @";‑)
;)	*-)
*)	;‑]
;]	;^)	:‑,
;D";

    /// <summary>
    /// Tongue sticking out, cheeky, playful emoticon patterns (XP, xp excluded due to OS name).
    /// </summary>
    public string TongueStickingOutCheekyPlayful { get; set; } = @":‑P
:P	X‑P
x‑p
:‑p
:p	:‑Þ
:Þ	:‑þ
:þ	:‑b
:b
d:
=p	>:P";

    /// <summary>
    /// Skeptical, annoyed, undecided, uneasy, hesitant emoticon patterns.
    /// </summary>
    public string SkepticalAnnoyedUndecidedUneasyHesitant { get; set; } = @":‑/
:‑.	>:\	>:/	:\	=/	=\		=L	:S";

    /// <summary>
    /// Indecision emoticon patterns.
    /// </summary>
    public string Indecision { get; set; } = @":‑|
:|";

    /// <summary>
    /// Embarrassed or blushing emoticon patterns.
    /// </summary>
    public string EmbarrassedBlushing { get; set; } = @":$	://)
://3";

    /// <summary>
    /// Tongue-tied emoticon patterns.
    /// </summary>
    public string TongueTied { get; set; } = @":‑X
:X	:‑#
:#	:‑&
:&";

    /// <summary>
    /// Angel or saint emoticon patterns (0:3 - 10:30).
    /// </summary>
    public string AngelSaint { get; set; } = @"O:‑)
O:)	0:‑3
0:‑)
0:)	0;^)";

    /// <summary>
    /// Evil emoticon patterns.
    /// </summary>
    public string Evil { get; set; } = @">:‑)
>:)	}:‑)
}:)	3:‑)
3:)
>;)	>:3
>;3";

    /// <summary>
    /// Tongue in cheek emoticon pattern.
    /// </summary>
    public string TongueInCheek { get; set; } = ":‑J";

    /// <summary>
    /// Partied all night emoticon pattern.
    /// </summary>
    public string PartiedAllNight { get; set; } = "#‑)";

    /// <summary>
    /// Drunk emoticon patterns.
    /// </summary>
    public string Drunk { get; set; } = @"%‑)
%)";

    /// <summary>
    /// Being sick emoticon patterns.
    /// </summary>
    public string BeingSick { get; set; } = @":‑###..
:###..";

    /// <summary>
    /// Dunce-like emoticon pattern.
    /// </summary>
    public string DunceLike { get; set; } = @"<:‑|";

    /// <summary>
    /// Disbelief emoticon patterns.
    /// </summary>
    public string Disbelief { get; set; } = "',:-|	',:-l";
}
