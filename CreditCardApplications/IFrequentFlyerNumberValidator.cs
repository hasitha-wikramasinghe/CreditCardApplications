namespace CreditCardApplications
{
    public interface ILicenseData
    {
        string LicenseKey { get; }
    }

    public interface IServiceInformation
    {
        ILicenseData License { get; }
    }

    public interface IFrequentFlyerNumberValidator
    {
        bool IsValid(string frequentFlyerNumber);

        bool IsValid(string frequentFlyerNumber, out bool isValid);

        //public string LicenseKey { get; }
        public IServiceInformation ServiceInformation { get; }

        public ValidationMode ValidationMode { get; set; }
    }
}