using BasketPriceCalculator.Entities;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BasketPriceCalculator.Services
{
    public class BasketPriceCalculator : IBasketPriceCalculator
    {
        public decimal Calculate(IReadOnlyList<BasketItem> basketItems, IReadOnlyList<Offer> offers = null)
        {
            return basketItems.Sum(x => x.Product.Price * x.Quantity);
        }
    }
}
