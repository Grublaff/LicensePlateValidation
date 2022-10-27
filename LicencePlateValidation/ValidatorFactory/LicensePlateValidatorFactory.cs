using LicensePlateValidation.LicensePlateValidators;

namespace LicensePlateValidation.ValidatorFactory;

public class LicensePlateValidatorFactory : ILicensePlateValidatorFactory
{
    public ILicensePlateValidator Create(string countryCode) => countryCode switch
    {
        "SE" => new SwedishLicensePlateValidator(),
        _ => throw new NotImplementedException($"The country code: {countryCode}, has not yet been implemented"),
    };

}