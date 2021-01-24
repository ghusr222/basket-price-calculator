using BasketPriceCalculator.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BasketPriceCalculator.Services
{
    public interface IBasketPriceCalculator
    {
        decimal Calculate(IReadOnlyList<BasketItem> basketItems);
    }
}
