using System;
using System.Collections.Generic;
using System.Text;

namespace BasketPriceCalculator.Entities
{
    public class Offer
    {
        public Product ConditionProduct { get; set; }
        public int ConditionQuantity { get; set; }
        public Product DiscountProduct { get; set; }
        public decimal DiscountFactor { get; set; }
    }
}
