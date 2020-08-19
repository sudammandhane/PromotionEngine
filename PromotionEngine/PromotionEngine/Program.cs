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

           
            #endregion

            //Temperaly Creating Default Order
            #region Creating Default Order

            List<Order> orders = new List<Order>();
            Order order1 = new Order(new List<Product>()
            {
                 new Product("A"),
                new Product("B"),
                new Product("C")
            });

            Order order2 = new Order(new List<Product>()
            {
                new Product("A"),
                new Product("A"),
                new Product("A"),
                new Product("A"),
                new Product("A"),
                new Product("B"),
                new Product("B"),
                new Product("B"),
                new Product("B"),
                new Product("B"),
                new Product("C")
            });

            Order order3 = new Order(new List<Product>()
            {
                new Product("A"),
                new Product("A"),
                new Product("A"),
                new Product("B"),
                new Product("B"),
                new Product("B"),
                new Product("B"),
                new Product("B"),
                new Product("C"),
                new Product("D")
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
