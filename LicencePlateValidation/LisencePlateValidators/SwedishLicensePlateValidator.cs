using System.Text.RegularExpressions;

namespace LicensePlateValidation.LicensePlateValidators;

public class SwedishLicensePlateValidator : ILicensePlateValidator
{
    public bool Validate(string licensePlateNumber)
    {
        var regex = new Regex(@"^[A-Za-z]{3}\d{3}$");

        return regex.IsMatch(licensePlateNumber);
    }
}