using System.Collections.Generic;

namespace PromotionEngine.Module
{
    public class Order
    {
        public List<Product> Products { get; set; }

        public Order(List<Product> products)
        {
            Products = products;
        }

        public int CheckOut()
        {
            return 0;
        }
    }
}
