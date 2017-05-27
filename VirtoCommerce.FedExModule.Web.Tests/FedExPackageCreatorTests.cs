using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirtoCommerce.Domain.Cart.Model;
using VirtoCommerce.FedExModule.Web.Integration;

namespace VirtoCommerce.FedExModule.Web.Tests
{
    [TestClass]
    public class FedExPackageCreatorTests
    {
        [TestMethod]
        public void CreateSinglePackageFromSingleItem()
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
                Items = new List<LineItem> { item }
            };

            var packages = FedExPackageCreator.CreatePackagesFromShoppingCart(shoppingCart);

            Assert.AreEqual(1, packages.Length);
            var package = packages.First();

            Assert.AreEqual(item.Weight ,package.Weight.Value);
            Assert.AreEqual(true, package.Weight.ValueSpecified);
            Assert.AreEqual(WeightUnits.LB, package.Weight.Units);
            Assert.AreEqual(true, package.Weight.UnitsSpecified);

            Assert.AreEqual("9.48", package.Dimensions.Height);
            Assert.AreEqual("9.48", package.Dimensions.Length);
            Assert.AreEqual("9.48", package.Dimensions.Width);
            Assert.AreEqual(LinearUnits.IN, package.Dimensions.Units);
            Assert.AreEqual(true, package.Dimensions.UnitsSpecified);
            Assert.AreEqual(PhysicalPackagingType.CARTON, package.PhysicalPackaging);
            Assert.AreEqual(true, package.PhysicalPackagingSpecified);
        }
    }
}