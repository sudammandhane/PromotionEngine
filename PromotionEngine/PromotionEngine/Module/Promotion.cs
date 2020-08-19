using System.Collections.Generic;

namespace PromotionEngine.Module
{
    public class Promotion
    {
        public Dictionary<string, int> ProductInfoDict { get; set; }
        public decimal PromoPrice { get; set; }

        public Promotion(Dictionary<string, int> prodInfoDict, decimal promoPrice)
        {
            ProductInfoDict = prodInfoDict;
            PromoPrice = promoPrice;
        }
    }
}
