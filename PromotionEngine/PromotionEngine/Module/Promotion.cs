using System.Collections.Generic;

namespace PromotionEngine.Module
{
    public class Promotion
    {
        public Dictionary<string, int> ProductInfoDict { get; set; }
        public int PromoPrice { get; set; }

        public Promotion(Dictionary<string, int> prodInfoDict, int promoPrice)
        {
            ProductInfoDict = prodInfoDict;
            PromoPrice = promoPrice;
        }
    }
}
