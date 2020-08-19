namespace PromotionEngine.Module
{
    public class Product
    {
        public string ProdcutName { get; set; }
        public decimal Price { get; set; }

        public Product(string prodcutName, int price)
        {
            ProdcutName = prodcutName;
            Price = price;
        }
    }
}
