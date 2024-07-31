namespace CreditCardApplications
{
    public class CreditCardApplication
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public decimal GrossAnnualIncome { get; set; }
        public string FrequentFlyerNumber { get; set; } = string.Empty;
    }
}