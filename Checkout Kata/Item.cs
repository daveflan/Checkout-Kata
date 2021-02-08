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
        string _itemNumber;
        decimal _ItemPrice;
        SpecialOffers _specialOffers;

        public string GetSKU()
        {
            return _itemSKU;
        }

        public string GetItemSKU()
        {
            return _itemNumber;
        }

        public void ApplySpecialOffers(SpecialOffers specialOffers)
        {
            _specialOffers = specialOffers;
        }

        public decimal GetItemPrice()
        {
            return _specialOffers.GetUnitPrice();
        }

       
    }
}
