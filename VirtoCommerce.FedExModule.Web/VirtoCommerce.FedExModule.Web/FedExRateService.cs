using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using VirtoCommerce.Domain.Cart.Model;
using VirtoCommerce.Domain.Commerce.Model;
using VirtoCommerce.Domain.Commerce.Services;
using VirtoCommerce.Domain.Shipping.Model;
using VirtoCommerce.FedExModule.Web.Integration;

namespace VirtoCommerce.FedExModule.Web
{
    public class FedExRateService
    {
        public IEnumerable<ShippingRate> GetRatesForShoppingCart(FedExShippingMethod fedExShippingMethod,
            ShoppingCart shoppingCart, FulfillmentCenter storeFulfillmentCenter, ICommerceService commerceService)
        {
            var shipperAddress = GetShipperAddress(shoppingCart, storeFulfillmentCenter, commerceService);

            var packages = FedExPackageCreator.CreatePackagesFromShoppingCart(shoppingCart);

            var rateService = new RateService(fedExShippingMethod.FedExSettings.WebServiceUrl);

            var rateRequest = CreateDefaultRateRequest(fedExShippingMethod.FedExSettings);
            rateRequest.RequestedShipment.RequestedPackageLineItems = packages;
            rateRequest.RequestedShipment.PackageCount = packages.Length.ToString();

            rateRequest.RequestedShipment.Shipper = new Party
            {
                Address = shipperAddress
            };

            rateRequest.RequestedShipment.Recipient = new Party
            {
                Address = GetRecipientAddress(shoppingCart)
            };

            var result = rateService.getRates(rateRequest);

            if (result.HighestSeverity != NotificationSeverityType.SUCCESS)
            {
                throw new Exception(
                    $"Request: {JsonConvert.SerializeObject(rateRequest)} Result: {JsonConvert.SerializeObject(result)}");
            }

            return result.RateReplyDetails.Select(r => new ShippingRate
            {
                Currency = "USD",
                DiscountAmount = 0,
                DiscountAmountWithTax = 0,
                OptionDescription = r.ServiceType.ToString(),
                OptionName = r.ServiceType.ToString(),
                Rate = r.RatedShipmentDetails[0].ShipmentRateDetail.TotalNetCharge.Amount,
                RateWithTax = r.RatedShipmentDetails[0].ShipmentRateDetail.TotalNetChargeWithDutiesAndTaxes.Amount,
                ShippingMethod = fedExShippingMethod
            });
        }

        private Integration.Address GetShipperAddress(ShoppingCart shoppingCart,
            FulfillmentCenter storeFulfillmentCenter, ICommerceService commerceService)
        {
            var shoppingCartFulfillmentCenter = storeFulfillmentCenter;
            var warehouseLocations = shoppingCart.Shipments.Select(s => s.WarehouseLocation).Distinct().ToList();
            var fulfillmentLocationCodes = shoppingCart.Items.Select(i => i.FulfillmentLocationCode).Distinct()
                .ToList();
            if (warehouseLocations.Any())
            {
                var allFulfillmentCenters = commerceService.GetAllFulfillmentCenters().ToList();
                var match = allFulfillmentCenters.FirstOrDefault(f => f.Id == warehouseLocations.First());
                if (match != null)
                {
                    shoppingCartFulfillmentCenter = match;
                }
                else if (fulfillmentLocationCodes.Any())
                {
                    match = allFulfillmentCenters.FirstOrDefault(f => f.Id == fulfillmentLocationCodes.First());
                    if (match != null)
                    {
                        shoppingCartFulfillmentCenter = match;
                    }
                }
            }

            if (shoppingCartFulfillmentCenter == null)
            {
                throw new Exception(
                    $"No configured or set fulfillment center. WarehouseLocations: {JsonConvert.SerializeObject(warehouseLocations)}  FulfillmentLocationCodes: {JsonConvert.SerializeObject(fulfillmentLocationCodes)} StoreFulfillmentCenter: {JsonConvert.SerializeObject(storeFulfillmentCenter)}");
            }

            return new Integration.Address
            {
                City = shoppingCartFulfillmentCenter.City,
                CountryCode = GetFedexCountryCode(shoppingCartFulfillmentCenter.CountryCode),
                CountryName = shoppingCartFulfillmentCenter.CountryName,
                PostalCode = shoppingCartFulfillmentCenter.PostalCode,
                Residential = true,
                ResidentialSpecified = true,
                StateOrProvinceCode = shoppingCartFulfillmentCenter.StateProvince,
                StreetLines = new[] {shoppingCartFulfillmentCenter.Line1},
                UrbanizationCode = string.Empty
            };
        }

        private string GetFedexCountryCode(string shoppingCartCountryCode)
        {
            if (shoppingCartCountryCode == "USA")
            {
                return "US";
            }

            return string.Empty;
        }

        private Integration.Address GetRecipientAddress(ShoppingCart shoppingCart)
        {
            try
            {
                var address = shoppingCart.Shipments.First().DeliveryAddress;
                return new Integration.Address
                {
                    City = address.City,
                    CountryCode = GetFedexCountryCode(address.CountryCode),
                    CountryName = address.CountryCode,
                    PostalCode = address.PostalCode,
                    Residential = true,
                    ResidentialSpecified = true,
                    StateOrProvinceCode = address.RegionId,
                    StreetLines = new[] {address.Line1},
                    UrbanizationCode = string.Empty
                };
            }
            catch (Exception)
            {
                throw new Exception($"Shopping Cart {JsonConvert.SerializeObject(shoppingCart)}");
            }
        }

        private RateRequest CreateDefaultRateRequest(FedexWebServiceSettings settings)
        {
            return new RateRequest
            {
                ClientDetail = new ClientDetail
                {
                    AccountNumber = settings.AccountNumber,
                    IntegratorId = settings.IntegratorId,
                    MeterNumber = settings.MeterNumber,
                    Region = ExpressRegionCode.US,
                    RegionSpecified = true
                },
                RequestedShipment = new RequestedShipment
                {
                    DropoffType = DropoffType.REGULAR_PICKUP,
                    DropoffTypeSpecified = true,
                    PackagingType = PackagingType.YOUR_PACKAGING,
                    PackagingTypeSpecified = true,
                    RateRequestTypes = new[] {RateRequestType.LIST},
                },
                ReturnTransitAndCommit = false,
                ReturnTransitAndCommitSpecified = false,
                Version = new VersionId(),
                WebAuthenticationDetail = new WebAuthenticationDetail
                {
                    ParentCredential = null,
                    UserCredential = new WebAuthenticationCredential
                    {
                        Key = settings.DeveloperKey,
                        Password = settings.Password
                    }
                }
            };
        }
    }
}