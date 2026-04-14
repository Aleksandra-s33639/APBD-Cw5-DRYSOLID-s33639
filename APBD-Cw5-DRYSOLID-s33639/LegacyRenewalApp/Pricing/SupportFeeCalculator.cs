namespace LegacyRenewalApp.Pricing
{
    public class SupportFeeCalculator
    {
        public decimal Calculate(string planCode, bool includePremiumSupport, ref string notes)
        {
            if (!includePremiumSupport)
                return 0;

            decimal supportFee = 0;

            if (planCode == "START")
                supportFee = 250m;
            else if (planCode == "PRO")
                supportFee = 400m;
            else if (planCode == "ENTERPRISE")
                supportFee = 700m;

            notes += "premium support included; ";

            return supportFee;
        }
    }
}