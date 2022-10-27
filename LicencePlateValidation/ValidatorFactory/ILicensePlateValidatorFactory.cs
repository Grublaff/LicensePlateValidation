using LicensePlateValidation.LicensePlateValidators;

namespace LicensePlateValidation.ValidatorFactory;

public interface ILicensePlateValidatorFactory
{
    ILicensePlateValidator? Create(string countryCode);
}