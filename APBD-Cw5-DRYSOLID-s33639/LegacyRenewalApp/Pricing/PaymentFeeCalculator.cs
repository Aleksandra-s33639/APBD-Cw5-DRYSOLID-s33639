namespace LegacyRenewalApp.Pricing
{
    public class PaymentFeeCalculator
    {
        public decimal Calculate(string paymentMethod, decimal amount, ref string notes)
        {
            decimal fee = 0;

            if (paymentMethod == "CARD")
            {
                fee = amount * 0.02m;
                notes += "card payment fee; ";
            }
            else if (paymentMethod == "BANK_TRANSFER")
            {
                fee = amount * 0.01m;
                notes += "bank transfer fee; ";
            }
            else if (paymentMethod == "PAYPAL")
            {
                fee = amount * 0.035m;
                notes += "paypal fee; ";
            }
            else if (paymentMethod == "INVOICE")
            {
                notes += "invoice payment; ";
            }
            else
            {
                throw new ArgumentException("Unsupported payment method");
            }

            return fee;
        }
    }
}