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

    [DataRow("ASDASD", "ABAC123")]
    [TestMethod]
    [ExpectedException(typeof(NotImplementedException))]
    public void Should_Return_Throw_Not_Implemented_Exception_When_No_Country_Code_Can_Be_Found(string CountryCode, string LicensePlate)
    {
        var prg = new Program();

        prg.ValidateLicensePlateNumber(CountryCode, LicensePlate);

        Assert.Fail();
    }
}
