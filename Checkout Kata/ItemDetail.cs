using System;

namespace Checkout_Kata
{
   
    public class ItemDetail
    {
        private Item _item;
        private int _quantity;

        public ItemDetail(Item item, int quantity)
        {
            _item = item;
            _quantity = quantity;
        }

        public decimal GetSKUCost()
        {
            return _item.GetItemPrice() * _quantity;
        }
    }



    
}
