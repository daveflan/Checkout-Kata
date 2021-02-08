using Microsoft.VisualStudio.TestTools.UnitTesting;
using Checkout_Kata;
using Moq;

namespace CheckoutKataTests
{
    [TestClass]
    public class Item_name
    {
        [TestMethod]
        public void All_items_have_a_SKU_code()
        {
            Item item = new Item("A99");
            Assert.AreEqual<string>(item.GetSKU(), "A99");
        }

        [TestMethod]
        public void Items_should_have_a_unique_sku()
        {
            Item item = new Item("A99");
            Item item2 = new Item("B15");

            Assert.IsFalse(item.GetSKU() == item2.GetSKU());
        }

        [TestMethod]
        public void Items_have_a_discount_based_on_sku_and_quantity()
        {
            var mockSpecialOffers = new Mock<SpecialOffers>();
            mockSpecialOffers.Setup((x) => x.GetSKuPrice()).Returns(0.5M);

            Item item = new Item("A99");
            item.ApplySpecialOffers(mockSpecialOffers.Object);

            decimal price = item.GetItemPrice();
            Assert.AreEqual<decimal>(0.5M, price);
        }

        [TestMethod]
        public void Apply_special_offers_based_on_item_count_and_SKUPrice()
        {
            int itemCount = 3;
            decimal totalPrice = 1.00M;
            OffersPricing countBasedPricing = new OffersPricing(itemCount, totalPrice);

            Item item = new Item("A99");
            item.ApplySpecialOffers(countBasedPricing);
            decimal itemPrice = item.GetItemPrice();

            decimal expectedPrice = totalPrice / itemCount;
            Assert.AreEqual(expectedPrice, itemPrice);
        }

        [TestMethod]
        public void Scanned_items_contain_multiple_items_and_quantities()
        {
            var ScanItems = new ScanItems();

            Item tesco = new Item("A99");
            OffersPricing TestOffer = new OffersPricing(3, 1.35M);
            tesco.ApplySpecialOffers(TestOffer);

            ItemDetail itemDetail = new ItemDetail(tesco, 3);

            ScanItems.Add(itemDetail);

            decimal totalPrice = ScanItems.GetTotalPrice();
            Assert.AreEqual(totalPrice, TestOffer.GetSKuPrice() * 3);

        }
    }
}

