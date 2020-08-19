using NUnit.Framework;
using PromotionEngine.Module;
using System.Collections.Generic;

namespace Tests
{
    public class PromotionTest
    {

        [Test]
        public void Check_Promotion_1()
        {
            Order order = new Order(new List<Product>()
            {
                new Product("A"),
                new Product("A"),
                new Product("A")
            });
            Assert.AreEqual(order.CheckOut(), 130);
        }

        [Test]
        public void Check_Promotion_2()
        {
            Order order = new Order(new List<Product>()
            {
                new Product("B"),
                new Product("B")
            });
            Assert.AreEqual(order.CheckOut(), 45);
        }

        [Test]
        public void Check_Promotion_3()
        {
            Order order = new Order(new List<Product>()
            {
                new Product("C"),
                new Product("D")
            });
            Assert.AreEqual(order.CheckOut(), 30);
        }
    }
}