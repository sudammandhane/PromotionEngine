using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine.Module
{
    public class Order
    {
        public static List<Promotion> Promotions { get; set; }
        public List<Product> Products { get; set; }
        
        public Order(List<Product> products)
        {
            Products = products;
        }

        /// <summary>
        /// This Method calculate final order price after applying promotions.
        /// Note: Lot of iterations. Need to optemize the below method.
        /// </summary>
        /// <returns></returns>
        public int CheckOut()
        {
            int total = 0;

            foreach (Promotion p in Promotions)
            {
                var itemGroups = Products.GroupBy(g => g.ProdcutName);
                //Check to validate that all promotion conditions satisfed
                while (p.ProductInfoDict.All(x => itemGroups.Any(y => y.Key == x.Key && y.Count() >= x.Value)))
                {

                    foreach (var prodInfo in p.ProductInfoDict)
                    {
                        //Removing Products which satisfy the Promotion
                        var productsToRemove = Products.Where(x => x.ProdcutName == prodInfo.Key).Take(prodInfo.Value).ToList();
                        foreach (var product in productsToRemove)
                        {                            
                            Products.Remove(product);
                        }
                    }
                    //Adding Promotion Price to total
                    total += p.PromoPrice;
                    //Again grouping as removed the products
                    itemGroups = Products.GroupBy(g => g.ProdcutName);
                }
            }

            total += Products.Sum(x => x.Price);
            return total;
        }
    }
}
