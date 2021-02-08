namespace Checkout_Kata
{
    public abstract class SpecialOffers
    {
        public abstract decimal GetSKuPrice();
    }

    public class OffersPricing : SpecialOffers
    {
        private decimal _unitPrice;

        public OffersPricing(decimal unitPrice)
        {
            _unitPrice = unitPrice;
        }

        public override decimal GetSKuPrice()
        {
            return _unitPrice;
        }
    }

}