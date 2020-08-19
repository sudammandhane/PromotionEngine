using PromotionEngine.Module;
using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Promotion

            //Create list of promotions
            List<Promotion> promotions = new List<Promotion>();

            //Adding First Promotion If A * 3 Then Price = 130
            Dictionary<String, int> prodInfo = new Dictionary<String, int>
            {
                { "A", 3 }
            };
            promotions.Add(new Promotion(prodInfo, 130));

            //Adding Second Promotion If B * 2 Then Price = 45
            prodInfo = new Dictionary<String, int>
            {
                { "B", 2 }
            };
            promotions.Add(new Promotion(prodInfo, 45));

            //Adding Third Promotion If C + D Then Price = 30
            prodInfo = new Dictionary<String, int>
            {
                { "C", 1 },
                { "D", 1 }
            };
            promotions.Add(new Promotion(prodInfo, 30));

            Order.Promotions = promotions;
            #endregion

            //Temperaly Creating Default Order
            #region Creating Default Order

            List<Order> orders = new List<Order>();
            Order order1 = new Order(new List<Product>()
            {
                new Product("A", 50),
                new Product("B", 30),
                new Product("C", 20)
            });

            Order order2 = new Order(new List<Product>()
            {
                new Product("A", 50),
                new Product("A", 50),
                new Product("A", 50),
                new Product("A", 50),
                new Product("A", 50),
                new Product("B", 30),
                new Product("B", 30),
                new Product("B", 30),
                new Product("B", 30),
                new Product("B", 30),
                new Product("C", 20)
            });

            Order order3 = new Order(new List<Product>()
            {
                new Product("A", 50),
                new Product("A", 50),
                new Product("A", 50),
                new Product("B", 30),
                new Product("B", 30),
                new Product("B", 30),
                new Product("B", 30),
                new Product("B", 30),
                new Product("C", 20),
                new Product("D", 15)
            });

            orders.AddRange(new Order[] { order1, order2, order3 });
            #endregion

            foreach (Order ord in orders)
            {
                Console.WriteLine("Order Price: " + ord.CheckOut().ToString("0.00"));
            }
            Console.ReadLine();
        }
    }
}
