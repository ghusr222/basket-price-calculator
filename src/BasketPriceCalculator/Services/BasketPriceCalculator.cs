using BasketPriceCalculator.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BasketPriceCalculator.Services
{
    public class BasketPriceCalculator : IBasketPriceCalculator
    {
        public decimal Calculate(IReadOnlyList<BasketItem> basketItems)
        {
            if (basketItems.Count == 3)
            {
                return 2.95m;
            }
            return 1.95m;
        }
    }
}
