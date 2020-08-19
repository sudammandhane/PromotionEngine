namespace PromotionEngine.Module
{
    public class Product
    {
        public string ProdcutName { get; set; }
        public int Price { get; set; }

        public Product(string prodcutName)
        {
            ProdcutName = prodcutName;
            switch (ProdcutName)
            {
                case "A":
                    Price = 50;

                    break;
                case "B":
                    Price = 30;

                    break;
                case "C":
                    Price = 20;

                    break;
                case "D":
                    Price = 15;
                    break;
            }
        }
    }
}
