using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout_Kata
{
    public class ScanItems
    {
        public ScanItems()
        {
            _itemDetails = new List<ItemDetail>();
        }

        public void Add(ItemDetail itemDetail)
        {
            _itemDetails.Add(itemDetail);
        }

        List<ItemDetail> _itemDetails;

        public decimal GetTotalPrice()
        {
            var totalPrice = 0.0M;
            foreach (var itemDetail in _itemDetails)
                totalPrice += itemDetail.GetSKUCost();

            return totalPrice;
        }
    }
}
