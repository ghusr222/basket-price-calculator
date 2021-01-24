using BasketPriceCalculator.Entities;
using BasketPriceCalculator.Services;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;
using BasketPriceCalculatorService = BasketPriceCalculator.Services.BasketPriceCalculator;

namespace BasketPriceCalculator.Tests
{
    public class BasketPriceCalculatorTests
    {
        private BasketPriceCalculatorService _sut;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            _sut = new BasketPriceCalculatorService();
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Calculate_OneBreadOneMilkOneButter_ReturnsValue()
        {
            var basketItems = new List<BasketItem>
            {
                new BasketItem { Product=new Product{ Name="Bread", Price=1.0m }, Quantity=1 },
                new BasketItem { Product=new Product{ Name="Milk", Price=1.15m }, Quantity=1 },
                new BasketItem { Product=new Product{ Name="Butter", Price=0.8m }, Quantity=1 }
            };

            var result = _sut.Calculate(basketItems);

            Assert.AreEqual(2.95m, result);
        }

        [Test]
        public void Calculate_OneBreadOneMilk_ReturnsValue()
        {
            var basketItems = new List<BasketItem>
            {
                new BasketItem { Product=new Product{ Name="Bread", Price=0.8m }, Quantity=1 },
                new BasketItem { Product=new Product{ Name="Milk", Price=1.15m }, Quantity=1 },
            };

            var result = _sut.Calculate(basketItems);

            Assert.AreEqual(1.95m, result);
        }

        [Test]
        public void Calculate_TwoButterTwoBread_ReturnsValueWithDiscount()
        {
            var basketItems = new List<BasketItem>
            {
                new BasketItem { Product=new Product{ Name="Butter", Price=0.8m }, Quantity=1 },
                new BasketItem { Product=new Product{ Name="Bread", Price=1.0m }, Quantity=1 },
            };

            var offers = new List<Offer>
            {
                new Offer {
                    ConditionProduct=new Product{Name="Butter", Price=0.8m },
                    ConditionQuantity=2,
                    DiscountProduct=new Product{Name="Bread", Price=1.0m},
                    DiscountFactor=0.5m
                }
            };

            var result = _sut.Calculate(basketItems, offers);

            Assert.AreEqual(3.1m, result);
        }


    }
}