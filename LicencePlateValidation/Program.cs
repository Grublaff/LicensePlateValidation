using LicensePlateValidation.ValidatorFactory;

namespace LicensePlateValidation;

public class Program
{

    public bool ValidateLicensePlateNumber(string countryCode, string registrationNumber)
    {
        if(countryCode is null)
            throw new ArgumentNullException(nameof(countryCode));
        if (registrationNumber is null)
            throw new ArgumentNullException(nameof(registrationNumber));


        var validator = new LicensePlateValidatorFactory();
        validator.Create(countryCode).Validate(registrationNumber);

        return validator.Create(countryCode).Validate(registrationNumber);
    }

}
