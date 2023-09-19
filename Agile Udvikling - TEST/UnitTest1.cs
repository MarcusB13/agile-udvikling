using Agile_Udvikling;

namespace Agile_Udvikling___TEST;

public class UnitTest1
{
    [Theory]
    [InlineData("Oliver","Bager","olivbage")]
    [InlineData("JørGen", "Jensen", "jørgjens")]
    [InlineData("Ib", "Larsen", "ibXXlars")]
    [InlineData("MA GNUS", "Høg", "magnhøgX")]
    [InlineData("Jo", "I b", "joXXibXX")]


    public void TestData(string sirname, string surname, string resultId)
    {
        string sirnameOutput = Program.GetNameId(sirname);
        string surnameOutput = Program.GetNameId(surname);
        string id = sirnameOutput + surnameOutput;

        Assert.Equal(resultId, id);
    } 

}
