namespace SunamoValues.Tests;

/// <summary>
/// Tests for the public character constants.
/// </summary>
public class AllCharsTests
{
    /// <summary>
    /// Every character constant that has a one-character namesake in AllStrings holds the same character.
    /// </summary>
    [Fact]
    public void AllChars_MatchOneCharacterConstantsOfAllStrings()
    {
        var checkedCount = 0;
        foreach (var field in typeof(AllChars).GetFields())
        {
            var namesake = typeof(AllStrings).GetField(field.Name);
            if (namesake == null || namesake.FieldType != typeof(string))
            {
                continue;
            }

            var text = (string)namesake.GetRawConstantValue()!;
            Assert.Equal(text, ((char)field.GetRawConstantValue()!).ToString());
            checkedCount++;
        }

        Assert.True(checkedCount > 30);
        Assert.Equal('/', AllChars.slash);
        Assert.Equal('?', AllChars.q);
        Assert.Equal('!', AllChars.excl);
        Assert.Equal(',', AllChars.comma);
    }
}
