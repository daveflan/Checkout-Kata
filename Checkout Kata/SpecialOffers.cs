namespace Checkout_Kata
{
    public abstract class SpecialOffers
    {
        public abstract decimal GetSKuPrice();
    }

    public class OffersPricing : SpecialOffers
    {
        private int _itemCount;
        private decimal _totalPrice;

        public OffersPricing(int itemCount, decimal totalPrice)
        {
            _itemCount = itemCount;
            _totalPrice = totalPrice;
        }

        public override decimal GetSKuPrice()
        {
            return _totalPrice / _itemCount;
        }
    }

}