namespace LegacyRenewalApp.Pricing
{
    public class TaxCalculator
    {
        public decimal GetTaxRate(string country)
        {
            if (country == "Poland") return 0.23m;
            if (country == "Germany") return 0.19m;
            if (country == "Czech Republic") return 0.21m;
            if (country == "Norway") return 0.25m;

            return 0.20m;
        }
    }
}