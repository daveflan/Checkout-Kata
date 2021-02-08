using System;

namespace Checkout_Kata
{
    public class Item
    {
        public Item(string itemSKU)
        {
            _itemSKU = itemSKU;           
        }               

        string _itemSKU;     
     
        SpecialOffers _specialOffers;

        public string GetSKU()
        {
            return _itemSKU;
        }             

        public void ApplySpecialOffers(SpecialOffers specialOffers)
        {
            _specialOffers = specialOffers;
        }

        public decimal GetItemPrice()
        {
            return _specialOffers.GetSKuPrice();
        }

    }
}
