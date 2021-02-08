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

            Assert.IsFalse(item.GetItemSKU() == item2.GetItemSKU());
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
    }
}

