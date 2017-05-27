using System;
using System.Globalization;
using VirtoCommerce.Domain.Cart.Model;
using VirtoCommerce.FedExModule.Web.Integration;

namespace VirtoCommerce.FedExModule.Web
{
    public class FedExPackageCreator
    {
        public static RequestedPackageLineItem[] CreatePackagesFromShoppingCart(ShoppingCart shoppingCart)
        {
            double totalVolume = 0;
            decimal totalWeight = 0;

            foreach (var shoppingCartItem in shoppingCart.Items)
            {
                // Cubic whatever he measurement is.
                double height = Convert.ToDouble(shoppingCartItem.Height ?? 0);
                double width = Convert.ToDouble(shoppingCartItem.Width ?? 0);
                double length = Convert.ToDouble(shoppingCartItem.Length ?? 0);

                double volume = height * width * length;
                
                var measureUnit = shoppingCartItem.MeasureUnit;
                if (measureUnit.ToLowerInvariant() != "in")
                {
                    // convert
                }

                totalWeight += (shoppingCartItem.Weight ?? 0.25m) * shoppingCartItem.Quantity;
                totalVolume += volume;
            }
            
            var packageDimension = Math.Round(totalVolume.ToCubeDimension() * 1.05, 2, MidpointRounding.AwayFromZero).ToString(CultureInfo.InvariantCulture);

            var package = new RequestedPackageLineItem
            {
                ContentRecords = new ContentRecord[0],
                CustomerReferences = new CustomerReference[0],
                Dimensions = new Dimensions
                {
                    Height = packageDimension,
                    Length = packageDimension,
                    Units = LinearUnits.IN,
                    UnitsSpecified = true,
                    Width = packageDimension
                },
                GroupNumber = string.Empty,
                GroupPackageCount = string.Empty,
                InsuredValue = null,
                ItemDescription = string.Empty,
                ItemDescriptionForClearance = string.Empty,
                PhysicalPackaging = PhysicalPackagingType.CARTON,
                PhysicalPackagingSpecified = true,
                SequenceNumber = string.Empty,
                SpecialServicesRequested = null,
                VariableHandlingChargeDetail = null,
                Weight = new Weight
                {
                    Units = WeightUnits.LB,
                    UnitsSpecified = true,
                    Value = totalWeight,
                    ValueSpecified = true
                }
            };

            return new[] { package };
        }
    }
}