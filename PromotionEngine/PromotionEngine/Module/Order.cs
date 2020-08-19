using System;
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

        static Order()
        {
            //Create list of promotions
            Promotions = new List<Promotion>();

            //Adding First Promotion If A * 3 Then Price = 130
            Dictionary<String, int> prodInfo = new Dictionary<String, int>
            {
                { "A", 3 }
            };
            Promotions.Add(new Promotion(prodInfo, 130));

            //Adding Second Promotion If B * 2 Then Price = 45
            prodInfo = new Dictionary<String, int>
            {
                { "B", 2 }
            };
            Promotions.Add(new Promotion(prodInfo, 45));

            //Adding Third Promotion If C + D Then Price = 30
            prodInfo = new Dictionary<String, int>
            {
                { "C", 1 },
                { "D", 1 }
            };
            Promotions.Add(new Promotion(prodInfo, 30));
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
