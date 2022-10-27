using LicensePlateValidation;

namespace LicensePlateValidatorTest;

[TestClass]
public class ValidatorTest
{
    [DataRow("SE", "ABC123")]
    [TestMethod]
    public void Should_Return_True_When_Valid_License_Plate(string CountryCode, string LicensePlate)
    {
        var prg = new Program();

        var result = prg.ValidateLicensePlateNumber(CountryCode, LicensePlate);

        Assert.AreEqual(result, true);
    }

    [DataRow("SE", "ABAC123")]
    [TestMethod]
    public void Should_Return_False_When_Non_Valid_License_Plate(string CountryCode, string LicensePlate)
    {
        var prg = new Program();

        var result = prg.ValidateLicensePlateNumber(CountryCode, LicensePlate);

        Assert.AreEqual(result, false);
    }
}
