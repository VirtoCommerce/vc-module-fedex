using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirtoCommerce.Domain.Cart.Model;
using VirtoCommerce.Domain.Commerce.Model;

namespace VirtoCommerce.FedExModule.Web.Tests
{
    [TestClass]
    public class FedExRateServiceTests
    {
        [TestMethod]
        public void RateSingleItemShoppingCart()
        {
            var item = new LineItem
            {
                Height = 11.75m,
                Weight = 4,
                Length = 9.85m,
                MeasureUnit = "in",
                Quantity = 1,
                RequiredShipping = true,
                WeightUnit = "lb",
                Width = 6.36m
            };
            var shoppingCart = new ShoppingCart
            {
                Items = new List<LineItem> {item},
                Addresses = new List<Address>
                {
                    new Address
                    {
                        AddressType = AddressType.Shipping,
                        City = "Lehi",
                        CountryName = "United States",
                        CountryCode = "US",
                        PostalCode = "84043",
                        Name = "Montane Hamilton",
                        Email = "montane@montane.org",
                        FirstName = "Montane",
                        LastName = "Hamilton",
                        Line1 = "5258 N Grey Hawk Dr",
                        Zip = "84043",
                        RegionId = "UT"
                    }
                }
            };

            var rateService = new FedExRateService();
            var settings = new FedexWebServiceSettings
            {
                AccountNumber = "510087160",
                DeveloperKey = "a44TY4WGoNLCONGI",
                IntegratorId = "123",
                MeterNumber = "118823858",
                WebServiceUrl = "https://wsbeta.fedex.com:443/web-services",
                Password = "vNwtV1TisgkpzVDmCzWFPNpuW"
            };
            var shippingMethod = new FedExShippingMethod(settings, "fedex");

            var result = rateService.GetRatesForShoppingCart(shippingMethod, shoppingCart);
        }
    }
}
