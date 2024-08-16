namespace CreditCardApplications
{
    public class FrequentFlyerNumberValidator : IFrequentFlyerNumberValidator
    {
        public bool IsValid(string frequentFlyerNumber)
        {
            throw new NotImplementedException("Simulate this real dependency being hard to use");
        }

        public bool IsValid(string frequentFlyerNumber, out bool isValid)
        {
            throw new NotImplementedException("Simulate this real dependency being hard to use");
        }

        public event EventHandler validatorLookupPerformed;

        //public string LicenseKey
        //{
        //    get
        //    {
        //        throw new NotImplementedException("For demo purposes");
        //    }
        //}

        public IServiceInformation ServiceInformation => throw new NotImplementedException();

        public ValidationMode ValidationMode
        {
            get => throw new NotImplementedException("For demo purposes only");
            set => throw new NotImplementedException("For demo purposes only");
        }
    }
}