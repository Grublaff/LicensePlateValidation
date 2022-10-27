namespace LicensePlateValidation.LicensePlateValidators;

public interface ILicensePlateValidator
{
    bool Validate(string licensePlateNumber);
}